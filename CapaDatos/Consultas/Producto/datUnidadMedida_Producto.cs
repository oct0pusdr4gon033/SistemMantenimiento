using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidad.Producto;
using CapaDatos.ConexionDB;
using System.Data;

namespace CapaDatos.Consultas.Producto
{
    public class datUnidadMedida_Producto
    {
        private static readonly datUnidadMedida_Producto _instancia = new datUnidadMedida_Producto();
        public static datUnidadMedida_Producto Instancia => _instancia;

        private datUnidadMedida_Producto() { }

        // LISTAR
        public List<entUnidadMedida_Producto> ListarUnidades()
        {
            List<entUnidadMedida_Producto> lista = new List<entUnidadMedida_Producto>();

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_ListarUnidadMedida", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(new entUnidadMedida_Producto
                        {
                            id_unidad = Convert.ToInt32(dr["id_unidad"]),
                            nombre_unidad = dr["nombre_unidad"].ToString(),
                            abreviatura = dr["abreviatura"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron listar las unidades. " + ex.Message);
            }

            return lista;
        }

        // REGISTRAR
        public bool RegistrarUnidad(entUnidadMedida_Producto unidad)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_RegistrarUnidadMedida", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre_unidad", unidad.nombre_unidad);
                    cmd.Parameters.AddWithValue("@abreviatura", unidad.abreviatura);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la unidad. " + ex.Message);
            }
        }

        // ACTUALIZAR
        public bool ActualizarUnidad(entUnidadMedida_Producto unidad)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_ActualizarUnidadMedida", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_unidad", unidad.id_unidad);
                    cmd.Parameters.AddWithValue("@nombre_unidad", unidad.nombre_unidad);
                    cmd.Parameters.AddWithValue("@abreviatura", unidad.abreviatura);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la unidad. " + ex.Message);
            }
        }

        // ELIMINAR
        public bool EliminarUnidad(int id_unidad)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_EliminarUnidadMedida", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_unidad", id_unidad);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la unidad. " + ex.Message);
            }
        }
    }
}
