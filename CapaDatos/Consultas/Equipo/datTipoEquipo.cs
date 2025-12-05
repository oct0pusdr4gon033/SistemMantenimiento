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
    public class datTipoEquipo
    {
        private readonly static datTipoEquipo _instancia = new datTipoEquipo();

        public static datTipoEquipo Instancia
        {
            get { return datTipoEquipo._instancia; }
        }

        #region "Metodos"

        // 1. LISTAR
        public List<entTipoEquipo> ListarTipoEquipo()
        {
            List<entTipoEquipo> lista = new List<entTipoEquipo>();
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarTipoEquipo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new entTipoEquipo()
                                {
                                    id_tipo_equipo = Convert.ToInt32(dr["id_tipo_equipo"]),
                                    nombre_tipo_equipo = dr["nombre_tipo_equipo"].ToString()
                                });
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        // 2. INSERTAR (Ahora devuelve la entidad con su ID nuevo)
        public entTipoEquipo InsertarTipoEquipo(entTipoEquipo obj)
        {
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarTipoEquipo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre_tipo_equipo", obj.nombre_tipo_equipo);
                        conn.Open();
                        int idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                        obj.id_tipo_equipo = idGenerado;

                        return obj;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
 
        // 3. EDITAR
        public bool EditarTipoEquipo(entTipoEquipo obj)
        {
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EditarTipoEquipo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Aquí enviamos ambos parámetros
                        cmd.Parameters.AddWithValue("@id_tipo_equipo", obj.id_tipo_equipo);
                        cmd.Parameters.AddWithValue("@nombre_tipo_equipo", obj.nombre_tipo_equipo);

                        conn.Open();
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // 4. ELIMINAR
        public bool EliminarTipoEquipo(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EliminarTipoEquipo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_tipo_equipo", id);

                        conn.Open();
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // 5. BUSCAR
        public List<entTipoEquipo> BuscarTipoEquipo(string busqueda)
        {
            List<entTipoEquipo> lista = new List<entTipoEquipo>();
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_BuscarTipoEquipo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Pasamos lo que el usuario escribió en la caja de texto
                        cmd.Parameters.AddWithValue("@busqueda", busqueda);

                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new entTipoEquipo()
                                {
                                    id_tipo_equipo = Convert.ToInt32(dr["id_tipo_equipo"]),
                                    nombre_tipo_equipo = dr["nombre_tipo_equipo"].ToString()
                                });
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
