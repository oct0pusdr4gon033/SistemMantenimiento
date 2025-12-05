using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidad.Producto;
using CapaDatos.ConexionDB;

namespace CapaDatos.Consultas.Material
{
    public class datCategoria_Producto
    {
        private static readonly datCategoria_Producto _instancia = new datCategoria_Producto();
        public static datCategoria_Producto Instancia => _instancia;

        private datCategoria_Producto() { }

        // LISTAR CATEGORÍAS
        public List<entCategoria_Producto> ListarCategorias()
        {
            List<entCategoria_Producto> lista = new List<entCategoria_Producto>();

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Categoria", cn);
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
                throw new Exception("Error al listar categorías: " + ex.Message);
            }

            return lista;
        }

        // REGISTRAR CATEGORÍA
        public bool RegistrarCategoria(entCategoria_Producto cat)
        {
            bool ok = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Categoria(nombre_categoria) VALUES(@nombre)", cn);

                    cmd.Parameters.AddWithValue("@nombre", cat.nombre_categoria);

                    cn.Open();
                    ok = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar categoría: " + ex.Message);
            }

            return ok;
        }

        // ACTUALIZAR CATEGORÍA
        public bool ActualizarCategoria(entCategoria_Producto cat)
        {
            bool ok = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Categoria SET nombre_categoria=@nombre WHERE id_categoria=@id", cn);

                    cmd.Parameters.AddWithValue("@id", cat.id_categoria);
                    cmd.Parameters.AddWithValue("@nombre", cat.nombre_categoria);

                    cn.Open();
                    ok = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar categoría: " + ex.Message);
            }

            return ok;
        }

        // ELIMINAR CATEGORÍA
        public bool EliminarCategoria(int id)
        {
            bool ok = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Categoria WHERE id_categoria=@id", cn);

                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();
                    ok = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar categoría: " + ex.Message);
            }

            return ok;
        }
    }
}
