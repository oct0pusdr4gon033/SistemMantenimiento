using CapaEntidad.Equipo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Consultas.Equipo
{
    public class datHorometro
    {
        private static readonly datHorometro _instancia = new datHorometro();
        public static datHorometro Instancia
        {
            get { return datHorometro._instancia; }
        }

        public bool InsertarHorometro(entHorometro horometro)
        {
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarHorometro", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@horometro_anterior", horometro.horometro_anterior);
                        cmd.Parameters.AddWithValue("@hotometro_actual", horometro.hotometro_actual);
                        cmd.Parameters.AddWithValue("@fecha_registro", horometro.fecha_registro);
                        cmd.Parameters.AddWithValue("@descripcion", horometro.descripcion ?? string.Empty);
                        cmd.Parameters.AddWithValue("@id_equipo", horometro.id_equipo);
                        cmd.Parameters.AddWithValue("@id_empleado", horometro.id_empleado);
                        cmd.Parameters.AddWithValue("@diferencia", horometro.diferencia);

                        conn.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Horometro: " + ex.Message);
            }
        }

    }
}
