using CapaDatos.ConexionDB;
using CapaDatos.Consultas.Usuario;
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
    public class datEquipo
    {
        private static readonly datEquipo _instancia = new datEquipo();

        public static datEquipo Instancia
        {
            get { return datEquipo._instancia; }
        }

        #region metodos 
        /////////////////////////metodos de equipo
        ///Insertar equipo
        public entEquipo InsertarEquipo(entEquipo equipo)
        {

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_RegistrarEquipo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigo_flota", equipo.codigo_flota);
                        cmd.Parameters.AddWithValue("@marca", equipo.marca);
                        cmd.Parameters.AddWithValue("@modelo", equipo.modelo);
                        cmd.Parameters.AddWithValue("@tipo_equipo", equipo.tipo_equipo);
                        cmd.Parameters.AddWithValue("@anio_fabricacion", equipo.anio_fabricacion);
                        cmd.Parameters.AddWithValue("@horometro_inicial", equipo.horometro_inicial);
                        cmd.Parameters.AddWithValue("@horometro_actual", equipo.horometro_actual);
                        cmd.Parameters.AddWithValue("@fecha_registro", equipo.fecha_registro);
                        cmd.Parameters.AddWithValue("@num_serie", equipo.num_serie);
                        cmd.Parameters.AddWithValue("@fecha_compra", equipo.fecha_compra);
                        cmd.Parameters.AddWithValue("@estado", equipo.estado_equipo);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    throw new ApplicationException("Error SQL al insertar el equipo: " + sqlEx.Message, sqlEx);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error general al insertar el equipo: " + ex.Message, ex);
                }

                return equipo;
            }
        }

        #endregion

    }
}
