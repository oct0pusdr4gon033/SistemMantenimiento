using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Producto;

namespace CapaDatos.Consultas.Producto
{
    public class datCategoria_Producto
    {
        private static readonly datCategoria_Producto _instancia = new datCategoria_Producto();
        public static datCategoria_Producto Instancia => _instancia;

        private datCategoria_Producto() { }

        #region Métodos de acceso a datos

        // LISTAR CATEGORÍAS
        public List<entCategoria_Producto> ListarCategorias()
        {
            List<entCategoria_Producto> lista = new List<entCategoria_Producto>();

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_ListarCategoria", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new entCategoria_Producto
                        {
                            id_categoria = Convert.ToInt32(dr["id_categoria"]),
                            nombre_categoria = dr["nombre_categoria"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al listar categorías.", ex);
            }

            return lista;
        }

        // INSERTAR CATEGORÍA
        public bool RegistrarCategoria(entCategoria_Producto cat)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_InsertarCategoria", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", cat.nombre_categoria);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al registrar la categoría.", ex);
            }
        }

        // ACTUALIZAR CATEGORÍA
        public bool ActualizarCategoria(entCategoria_Producto cat)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_EditarCategoria", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", cat.id_categoria);
                    cmd.Parameters.AddWithValue("@nombre", cat.nombre_categoria);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al actualizar la categoría.", ex);
            }
        }

        // ELIMINAR CATEGORÍA
        public bool EliminarCategoria(int id)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_EliminarCategoria", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar la categoría.", ex);
            }
        }

        #endregion
    }
}

