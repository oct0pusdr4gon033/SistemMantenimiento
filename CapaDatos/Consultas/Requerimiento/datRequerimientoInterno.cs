using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad.Requerimiento;
using CapaDatos.ConexionDB;

namespace CapaDatos.Consultas.Requerimiento
{
    public class datRequerimientoInterno
    {
        private static readonly datRequerimientoInterno _instancia = new datRequerimientoInterno();
        public static datRequerimientoInterno Instancia => _instancia;

        // Registrar y devolver ID generado
        public int RegistrarRequerimiento(entRequerimientoInterno req)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_InsertarRequerimientoInterno", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_empleado", req.id_empleado);
                    cmd.Parameters.AddWithValue("@cod_req", req.cod_req);
                    cmd.Parameters.AddWithValue("@fech_req", req.fech_req);

                    SqlParameter output = new SqlParameter("@newId", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(output);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return (int)output.Value;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar requerimiento interno: " + ex.Message);
            }
        }

        // Listar todos
        public List<entRequerimientoInterno> Listar()
        {
            List<entRequerimientoInterno> lista = new List<entRequerimientoInterno>();

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_ListarRequerimientoInterno", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new entRequerimientoInterno
                    {
                        id_req = Convert.ToInt32(dr["id_req"]),
                        id_empleado = Convert.ToInt32(dr["id_empleado"]),
                        cod_req = dr["cod_req"].ToString(),
                        fech_req = Convert.ToDateTime(dr["fech_req"]),
                        nombre_empleado = dr["nombre_empleado"].ToString()
                    });
                }
            }
            return lista;
        }

        // Buscar por código y fecha
        public List<entRequerimientoInterno> BuscarPorCodigoYFecha(string codigo, DateTime fecha)
        {
            List<entRequerimientoInterno> lista = new List<entRequerimientoInterno>();

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_BuscarReqPorCodigoYFecha", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@fecha", fecha);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new entRequerimientoInterno
                    {
                        id_req = Convert.ToInt32(dr["id_req"]),
                        id_empleado = Convert.ToInt32(dr["id_empleado"]),
                        cod_req = dr["cod_req"].ToString(),
                        fech_req = Convert.ToDateTime(dr["fech_req"]),
                        nombre_empleado = dr["nombre_empleado"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
