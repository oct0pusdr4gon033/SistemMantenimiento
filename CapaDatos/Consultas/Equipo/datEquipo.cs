using CapaEntidad.Equipo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CapaDatos.Consultas.Equipo
{
    public class datEquipo
    {
        private static readonly datEquipo _instancia = new datEquipo();


        public static datEquipo Instancia
        {
            get { return datEquipo._instancia; }
        }

        #region metodos 
        /////////////////////////metodos de equipo
        ///Insertar equipo
        public entEquipo InsertarEquipo(entEquipo equipo)
        {

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_RegistrarEquipo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigo_flota", equipo.codigo_flota);
                        cmd.Parameters.AddWithValue("@marca", equipo.marca);
                        cmd.Parameters.AddWithValue("@modelo", equipo.modelo);
                        cmd.Parameters.AddWithValue("@tipo_equipo", equipo.tipo_equipo);
                        cmd.Parameters.AddWithValue("@anio_fabricacion", equipo.anio_fabricacion);
                        cmd.Parameters.AddWithValue("@horometro_inicial", equipo.horometro_inicial);
                        cmd.Parameters.AddWithValue("@horometro_actual", equipo.horometro_actual);
                        cmd.Parameters.AddWithValue("@fecha_registro", equipo.fecha_registro);
                        cmd.Parameters.AddWithValue("@num_serie", equipo.num_serie);
                        cmd.Parameters.AddWithValue("@fecha_compra", equipo.fecha_compra);
                        cmd.Parameters.AddWithValue("@estado", equipo.estado_equipo);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    throw new ApplicationException("Error SQL al insertar el equipo: " + sqlEx.Message, sqlEx);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error general al insertar el equipo: " + ex.Message, ex);
                }

                return equipo;
            }
        }
        ///////Estraer top 5 recientes 
        public List<entEquipo> extraer_top_five()
        {
            List<entEquipo> listaEquipos = new List<entEquipo>();

            using (SqlConnection con = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerUltimosCincoEquipos", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                entEquipo equipo = new entEquipo();
                                equipo.estado_equipo = Convert.ToBoolean(reader["estado"]);
                                equipo.codigo_flota = reader["codigo_flota"].ToString();
                                equipo.marca = reader["marca"].ToString();
                                equipo.modelo = reader["modelo"].ToString();
                                equipo.tipo_equipo = reader["tipo_equipo"].ToString();
                                equipo.horometro_inicial = Convert.ToInt32(reader["horometro_inicial"]);
                                equipo.horometro_actual = Convert.ToInt32(reader["horometro_actual"]);

                                equipo.num_serie = reader["num_serie"] == DBNull.Value
                                    ? null
                                    : reader["num_serie"].ToString();

                                equipo.anio_fabricacion = reader["anio_fabricacion"] == DBNull.Value
                                    ? 0
                                    : Convert.ToInt32(reader["anio_fabricacion"]);
                                equipo.fecha_compra = reader["fecha_compra"] == DBNull.Value
                                    ? DateTime.MinValue
                                    : Convert.ToDateTime(reader["fecha_compra"]);

                                equipo.fecha_registro = reader["fecha_registro"] == DBNull.Value
                                    ? DateTime.MinValue
                                    : Convert.ToDateTime(reader["fecha_registro"]);
                                listaEquipos.Add(equipo);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al extraer el top 5 de equipos: " + ex.Message);
                    }
                }
            }
            return listaEquipos;
        }

        /// Actualiza un equipo existente en la base de datos y registra el cambio en la bitácora.
        public bool ActualizarEquipo(entEquipo equipo, string usuarioEdito, string motivo)
        {
            bool actualizado = false;

            using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ActualizarEquipoPorId", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_equipo", equipo.id_equipo);
                    cmd.Parameters.AddWithValue("@codigo_flota", equipo.codigo_flota);
                    cmd.Parameters.AddWithValue("@marca", equipo.marca);
                    cmd.Parameters.AddWithValue("@modelo", equipo.modelo);
                    cmd.Parameters.AddWithValue("@num_serie", (object)equipo.num_serie ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@tipo_equipo", equipo.tipo_equipo);
                    cmd.Parameters.AddWithValue("@anio_fabricacion", equipo.anio_fabricacion);
                    cmd.Parameters.AddWithValue("@horometro_inicial", equipo.horometro_inicial);
                    cmd.Parameters.AddWithValue("@horometro_actual", equipo.horometro_actual);
                    cmd.Parameters.AddWithValue("@fecha_compra", (object)equipo.fecha_compra ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fecha_registro", (object)equipo.fecha_registro ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@estado", equipo.estado_equipo);

                    // 🔹 Nuevos parámetros para bitácora
                    cmd.Parameters.AddWithValue("@usuario_edito", usuarioEdito);
                    cmd.Parameters.AddWithValue("@motivo", motivo);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        actualizado = true;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error SQL al actualizar el equipo: " + ex.Message);
                    }
                }
            }

            return actualizado;
        }
        public List<entEquipo> BuscarEquipos(string tipo, string marca, int? año,
                                            string modelo, string fecha, string num_serie)
        {
            List<entEquipo> lista = new List<entEquipo>();

            // Conversión de fecha. Si 'fecha' no es válida, la dejamos como null
            DateTime? fechaValida = null;
            if (DateTime.TryParse(fecha, out DateTime tempFecha))
            {
                fechaValida = tempFecha;
            }

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_BuscarEquipos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // --- PARÁMETROS CORREGIDOS ---
                    // Esta forma es más segura para manejar strings vacíos y nulos
                    cmd.Parameters.AddWithValue("@Tipo", string.IsNullOrEmpty(tipo) ? (object)DBNull.Value : tipo);
                    cmd.Parameters.AddWithValue("@Marca", string.IsNullOrEmpty(marca) ? (object)DBNull.Value : marca);
                    cmd.Parameters.AddWithValue("@Anio", año.HasValue ? (object)año.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Modelo", string.IsNullOrEmpty(modelo) ? (object)DBNull.Value : modelo);
                    cmd.Parameters.AddWithValue("@FechaIngreso", fechaValida.HasValue ? (object)fechaValida.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@NumSerie", string.IsNullOrEmpty(num_serie) ? (object)DBNull.Value : num_serie);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    // --- LECTOR A PRUEBA DE CRASHES ---
                    while (dr.Read())
                    {
                        // Usamos el operador ternario (condición ? si_verdadero : si_falso)
                        // para comprobar si el valor es DBNull ANTES de convertirlo.
                        entEquipo equipo = new entEquipo
                        {
                            // ¡Llenamos la entidad completa!
                            id_equipo = dr["id_equipo"] == DBNull.Value ? 0 : Convert.ToInt32(dr["id_equipo"]),
                            codigo_flota = dr["codigo_flota"] == DBNull.Value ? "" : dr["codigo_flota"].ToString(),
                            tipo_equipo = dr["TipoEquipo"] == DBNull.Value ? "" : dr["TipoEquipo"].ToString(),
                            marca = dr["Marca"] == DBNull.Value ? "" : dr["Marca"].ToString(),
                            modelo = dr["Modelo"] == DBNull.Value ? "" : dr["Modelo"].ToString(),
                            num_serie = dr["num_serie"] == DBNull.Value ? "" : dr["num_serie"].ToString(),
                            fecha_registro = dr["FechaIngreso"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["FechaIngreso"]),
                            anio_fabricacion = dr["Fabricacion"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Fabricacion"]),
                            horometro_actual = dr["horometro_actual"] == DBNull.Value ? 0 : Convert.ToInt32(dr["horometro_actual"]),
                            estado_equipo = dr["estado"] == DBNull.Value ? false : Convert.ToBoolean(dr["estado"])
                        };
                        lista.Add(equipo);
                    }
                }
                catch (Exception ex)
                {
                    // Es buena idea lanzar el error para que la capa de lógica lo vea
                    throw new Exception("Error al buscar equipos desde la capa de datos: " + ex.Message, ex);
                }
            }

            return lista;
        }

        //////Metodo conteo de equipos --Funcion para contar el total de equipos de la BD--
        public int contar_equipos()
        {
            int total_equipos = 0;
            string query = "SELECT COUNT(*) FROM Equipo";

            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            total_equipos = Convert.ToInt32(resultado);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudieron contar los equipos.", ex);
            }

            return total_equipos;
        }
        /// Obtiene un equipo por su ID.
        public entEquipo obtener_equipos_id(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Buscar_Id", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);

                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                entEquipo equipo = new entEquipo
                                {
                                    id_equipo = Convert.ToInt32(dr["id_equipo"]),
                                    codigo_flota = dr["codigo_flota"].ToString(),
                                    marca = dr["marca"].ToString(),
                                    modelo = dr["modelo"].ToString(),
                                    num_serie = dr["num_serie"] == DBNull.Value ? string.Empty : dr["num_serie"].ToString(),
                                    tipo_equipo = dr["tipo_equipo"].ToString(),
                                    anio_fabricacion = dr["anio_fabricacion"] == DBNull.Value ? 0 : Convert.ToInt32(dr["anio_fabricacion"]),
                                    horometro_inicial = Convert.ToInt32(dr["horometro_inicial"]),
                                    horometro_actual = Convert.ToInt32(dr["horometro_actual"]),
                                    fecha_compra = dr["fecha_compra"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["fecha_compra"]),
                                    fecha_registro = dr["fecha_registro"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["fecha_registro"]),
                                    estado_equipo = dr["estado"] != DBNull.Value && Convert.ToBoolean(dr["estado"])
                                };

                                return equipo;
                            }
                            else
                            {
                                return null; // No se encontró el equipo
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el equipo por ID: {ex.Message}");
            }
        }

        public bool existe_bitacora(int id_equipo)
        {
            string query = "SELECT COUNT(*) FROM Bitacora_Equipo WHERE id_equipo = @id_equipo";

            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_equipo", id_equipo);
                        conn.Open();

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (SqlException ex)
            { 
                return false;
            }
        }
        public bool dar_baja()
        {
            string query = "UPDATE Equipo SET estado = 0 WHERE id_equipo = @id_equipo";
            using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;

                }
                ;
            };
        }




        #endregion

    }
}
