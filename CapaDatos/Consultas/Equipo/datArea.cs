using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Equipo;

namespace CapaDatos.Consultas.Equipo
{
    public class datArea
    {
        private static readonly datArea _instancia = new datArea();


        public static datArea Instancia
        {
            get { return datArea._instancia; }
        }

        /// <summary>
        /// Inserta un área en la base de datos
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public entArea InsertarArea(entArea area)
        {
            using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarArea", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@nombre_area", area.nombre_area);

                        conn.Open();
                        int filas_afectadas = cmd.ExecuteNonQuery();

                        if (filas_afectadas> 0)
                        {
                            return area; 
                        }else
                        {

                            return null; 
                        }
                    }catch(Exception ex)
                    {
                        throw ex; 
                    }
                }
    
            }

        }
        /// <summary>
        /// Lista todas las áreas desde la base de datos
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<entArea> ObtenerAreas()
        {
            List<entArea> areas = new List<entArea>();

            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarAreas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                entArea area = new entArea
                                {
                                    id_area = Convert.ToInt32(reader["id_area"]),
                                    nombre_area = reader["nombre_area"].ToString(),
                                };

                                areas.Add(area);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener áreas: {ex.Message}", ex);
            }

            return areas;
        }
        /// <summary>
        /// Elimina un área de la base de datos
        /// </summary>
        /// <param name="id_area_eliminar"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool EliminarArea(int id_area_eliminar)
        {
            using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EliminarArea", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_area", id_area_eliminar);
                        conn.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (SqlException ex)
                {

                    if (ex.Number == 547)
                    {
                        throw new Exception("No se puede eliminar el área porque" +
                            " ya está siendo usada (tiene equipos asignados).");
                    }
                    else
                    {

                        throw ex;
                    }
                }
                catch (Exception ex)
                {
                    // Errores generales de C#
                    throw ex;
                }
            }
        }
       

      






    }
}
