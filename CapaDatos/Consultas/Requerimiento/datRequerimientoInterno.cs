using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.ConexionDB;
using CapaEntidad.Requerimiento;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Consultas.Requerimiento
{
    public class datRequerimientoInterno
    {
        private static readonly datRequerimientoInterno _instancia = new datRequerimientoInterno();
        public static datRequerimientoInterno Instancia => _instancia;

        public List<entRequerimientoInterno> Listar()
        {
            List<entRequerimientoInterno> lista = new List<entRequerimientoInterno>();

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_ListarReqInterno", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new entRequerimientoInterno()
                    {
                        id_req = Convert.ToInt32(dr["id_req"]),
                        id_empleado = Convert.ToInt32(dr["id_empleado"]),
                        cod_req = dr["cod_req"].ToString(),
                        fech_req = Convert.ToDateTime(dr["fech_req"])
                    });
                }
            }
            return lista;
        }

        public void Insertar(entRequerimientoInterno r)
        {
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_InsertarReqInterno", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_empleado", r.id_empleado);
                cmd.Parameters.AddWithValue("@cod_req", r.cod_req);
                cmd.Parameters.AddWithValue("@fech_req", r.fech_req);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Editar(entRequerimientoInterno r)
        {
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_EditarReqInterno", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_req", r.id_req);
                cmd.Parameters.AddWithValue("@id_empleado", r.id_empleado);
                cmd.Parameters.AddWithValue("@cod_req", r.cod_req);
                cmd.Parameters.AddWithValue("@fech_req", r.fech_req);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
