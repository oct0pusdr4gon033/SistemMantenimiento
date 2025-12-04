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
    public class datMarca
    {
        private static readonly datMarca _instancia = new datMarca();
        public static datMarca Instancia
        {
            get { return datMarca._instancia; }
        }

        /// <summary>
        /// Inserta una marca en la base de datos
        /// </summary>
        /// <param name="marca"></param>
        /// <returns></returns>
        public entMarca InsertarMarca(entMarca marca)
        {
            using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarMarcaEquipo", conn))
                {
                    try
                    {
                        cmd.CommandType= CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre_marca", marca.nombre_marca);
                        conn.Open();
                        int filas_afectadas = cmd.ExecuteNonQuery();
                        if (filas_afectadas > 0)
                        {
                            return marca;
                        }
                        else
                        {
                            return null;
                        }

                    }
                    catch(Exception ex)
                    {
                        throw ex; 
                    }
                }
            }
        }


        /// <summary>
        /// Lista todas las marcas_equipo desde la base de datos
        /// </summary>
        /// <returns></returns>
        public List<entMarca> ListarMarcas()
        {
            List<entMarca> lista = new List<entMarca>();
            using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarMarcasEquipo", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                entMarca marca = new entMarca()
                                {
                                    id_marca = Convert.ToInt32(reader["id_marca"]),
                                    nombre_marca = reader["nombre_marca"].ToString()
                                };
                                lista.Add(marca);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    return lista;

                }
            }
        }


        /// <summary>
        /// Edita una marca de equipo en la base de datos
        /// </summary>
        /// <param name="marca"></param>
        /// <returns></returns>
        public bool EditarMarca(entMarca marca)
        {
            using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("sp_EditarMarcaEquipo", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_marca", marca.id_marca);
                        cmd.Parameters.AddWithValue("@nombre_marca", marca.nombre_marca);
                        conn.Open();
                        int filas_afectadas = cmd.ExecuteNonQuery();
                        return filas_afectadas > 0;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// Eliminar una marca de equipo en la base de datos
        /// </summary>
        /// <param name="id_marca"></param>
        /// <returns></returns>
        public bool EliminarMarca(int id_marca)
        {
            using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("sp_EliminarMarcaEquipo", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_marca", id_marca);
                        conn.Open();
                        int filas_afectadas = cmd.ExecuteNonQuery();
                        return filas_afectadas > 0;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }




    }
}
