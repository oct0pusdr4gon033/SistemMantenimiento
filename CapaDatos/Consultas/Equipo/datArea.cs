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

        public List<Area> ObtenerAreas()
        {
            List<Area> areas = new List<Area>();

            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerAreas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Area area = new Area
                                {
                                    IdArea = Convert.ToInt32(reader["IdArea"]),
                                    Codigo = reader["Codigo"].ToString(),
                                    Nombre = reader["Nombre"].ToString(),
                                    Descripcion = reader["Descripcion"] != DBNull.Value
                                        ? reader["Descripcion"].ToString()
                                        : string.Empty,
                                    Activo = Convert.ToBoolean(reader["Activo"])
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

        public Area ObtenerAreaPorId(int idArea)
        {
            Area area = null;
            string query = "sp_ObtenerAreaPorId";

            using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_area", idArea);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            area = new Area
                            {
                                IdArea = Convert.ToInt32(reader["id_area"]),
                                Codigo = reader["codigo"].ToString(),
                                Nombre = reader["nombre"].ToString(),
                                Descripcion = reader["descripcion"].ToString(),
                                Activo = Convert.ToBoolean(reader["activo"])
                            };
                        }
                    }
                }
            }

            return area;
        }






    }
}
