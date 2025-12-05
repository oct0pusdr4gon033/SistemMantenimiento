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
    public class datUnidadMedida_Producto
    {
        private static readonly datUnidadMedida_Producto _instancia = new datUnidadMedida_Producto();
        public static datUnidadMedida_Producto Instancia => _instancia;

        private datUnidadMedida_Producto() { }

        // LISTAR UNIDADES
        public List<entUnidadMedida> ListarUnidades()
        {
            List<entUnidadMedida> lista = new List<entUnidadMedida>();

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("SELECT id_unidad, nombre_unidad, abreviatura FROM Unidad_Medida", cn);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new entUnidadMedida
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
                throw new Exception("Error al listar unidades: " + ex.Message);
            }

            return lista;
        }

        // REGISTRAR
        public bool RegistrarUnidad(entUnidadMedida unidad)
        {
            bool ok = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO Unidad_Medida(nombre_unidad, abreviatura)
                        VALUES (@nombre, @abreviatura)", cn);

                    cmd.Parameters.AddWithValue("@nombre", unidad.nombre_unidad);
                    cmd.Parameters.AddWithValue("@abreviatura", unidad.abreviatura);

                    cn.Open();
                    ok = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar unidad: " + ex.Message);
            }

            return ok;
        }

        // ACTUALIZAR
        public bool ActualizarUnidad(entUnidadMedida unidad)
        {
            bool ok = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(@"
                        UPDATE Unidad_Medida SET
                            nombre_unidad=@nombre,
                            abreviatura=@abreviatura
                        WHERE id_unidad=@id", cn);

                    cmd.Parameters.AddWithValue("@id", unidad.id_unidad);
                    cmd.Parameters.AddWithValue("@nombre", unidad.nombre_unidad);
                    cmd.Parameters.AddWithValue("@abreviatura", unidad.abreviatura);

                    cn.Open();
                    ok = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar unidad: " + ex.Message);
            }

            return ok;
        }

        // ELIMINAR
        public bool EliminarUnidad(int id)
        {
            bool ok = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Unidad_Medida WHERE id_unidad=@id", cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();
                    ok = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar unidad: " + ex.Message);
            }

            return ok;
        }
    }
}
