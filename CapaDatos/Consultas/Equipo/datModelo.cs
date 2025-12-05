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
    public class datModelo
    {
        private static readonly datModelo _instancia = new datModelo();


        public static datModelo Instancia
        {
            get { return datModelo._instancia; }
        }


        /// <summary>
        /// Inserta un Modelo_Marca en la base de datos
        /// </summary>
        /// <param name="modelo"></param>
        /// <returns></returns>
        public entModelo InsertarModelo(entModelo modelo)
        {
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd= new SqlCommand ("sp_InsertarModeloEquipo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@id_modelo", modelo.id_modelo);
                        cmd.Parameters.AddWithValue("@id_marca", modelo.id_marca);
                        cmd.Parameters.AddWithValue("@nombre_modelo", modelo.nombre_modelo);
                        conn.Open();
                        int filas_afectadas = cmd.ExecuteNonQuery();
                        if (filas_afectadas > 0)
                        {
                            return modelo;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }catch (SqlException ex) 
            {
                throw ex;
            }
        }

        /// <summary>
        /// Editar un Modelo_Marca en la base de datos
        /// </summary>
        /// <param name="modelo"></param>
        /// <returns></returns>
        public bool EditarModelo(entModelo modelo)
        {
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd= new SqlCommand ("sp_EditarModeloEquipo", conn))
                    {
                        cmd.CommandType= CommandType.StoredProcedure;
                        // --- AGREGA ESTA LÍNEA QUE FALTABA ---
                        cmd.Parameters.AddWithValue("@id_modelo_equipo", modelo.id_modelo_equipo);
                        // -------------------------------------
                        cmd.Parameters.AddWithValue("@id_marca", modelo.id_marca);
                        cmd.Parameters.AddWithValue("@nombre_modelo", modelo.nombre_modelo);

                        conn.Open();
                        int filas_afectadas = cmd.ExecuteNonQuery();
                        return filas_afectadas > 0;
                    }
                }
            }catch
            {
                throw; 
            }
        }

        public bool EliminarModelo(int id_modelo_equipo)
        {
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand ("sp_EliminarModeloEquipo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_modelo_equipo", id_modelo_equipo);
                        conn.Open();
                        int filas_afectadas= cmd.ExecuteNonQuery();
                        return filas_afectadas> 0;
              

                    }
                }
            }catch
            {
                throw; 
            }
        }

        public List<entModelo> ListarModelos()
        {
            List<entModelo> lista_modelos = new List<entModelo>();
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand ("sp_ListarModeloEquipo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                entModelo modelo = new entModelo()
                                {
                                    id_modelo_equipo = Convert.ToInt32(reader["id_modelo_equipo"]),
                                    id_marca = Convert.ToInt32(reader["id_marca"]),
                                    nombre_modelo = reader["nombre_modelo"].ToString(),
                                    nombre_marca = reader["nombre_marca"].ToString()
                                };
                                lista_modelos.Add(modelo);
                            }
                        }
                    }
                }
                return lista_modelos;
            }catch
            {
                throw; 
            }
        }

        public List<entModelo> BuscarModelo(string texto)
        {
            List<entModelo> lista = new List<entModelo>();

            using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("sp_BuscarModeloEquipo", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@texto_busqueda", texto);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                entModelo modelo = new entModelo()
                                {
                                    id_modelo_equipo = Convert.ToInt32(reader["id_modelo_equipo"]),
                                    id_marca = Convert.ToInt32(reader["id_marca"]),
                                    nombre_marca = reader["nombre_marca"].ToString(),
                                    nombre_modelo = reader["nombre_modelo"].ToString()
                                };

                                lista.Add(modelo);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al buscar modelo: " + ex.Message, ex);
                    }
                }
            }

            return lista;
        }


    }
}
