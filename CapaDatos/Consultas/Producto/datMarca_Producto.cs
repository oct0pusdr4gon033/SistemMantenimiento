using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Producto;
using System.Data.SqlClient;
using CapaDatos.ConexionDB;

namespace CapaDatos.Consultas.Material
{
    public class datMarca_Producto
    {
        private static readonly datMarca_Producto _instancia = new datMarca_Producto();
        public static datMarca_Producto Instancia => _instancia;

        private datMarca_Producto() { }

        // LISTAR
        public List<entMarca_Producto> ListarMarcas()
        {
            List<entMarca_Producto> lista = new List<entMarca_Producto>();

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Marca", cn);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new entMarca_Producto
                        {
                            id_marca = Convert.ToInt32(dr["id_marca"]),
                            nombre_marca = dr["nombre_marca"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar marcas: " + ex.Message);
            }

            return lista;
        }

        // INSERTAR
        public bool RegistrarMarca(entMarca_Producto m)
        {
            bool ok = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Marca(nombre_marca) VALUES (@nombre)", cn);

                    cmd.Parameters.AddWithValue("@nombre", m.nombre_marca);

                    cn.Open();
                    ok = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar marca: " + ex.Message);
            }

            return ok;
        }

        // ACTUALIZAR
        public bool ActualizarMarca(entMarca_Producto m)
        {
            bool ok = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Marca SET nombre_marca=@nombre WHERE id_marca=@id", cn);

                    cmd.Parameters.AddWithValue("@id", m.id_marca);
                    cmd.Parameters.AddWithValue("@nombre", m.nombre_marca);

                    cn.Open();
                    ok = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar marca: " + ex.Message);
            }

            return ok;
        }

        // ELIMINAR
        public bool EliminarMarca(int id)
        {
            bool ok = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Marca WHERE id_marca=@id", cn);

                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();
                    ok = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar marca: " + ex.Message);
            }

            return ok;
        }
    }
}
