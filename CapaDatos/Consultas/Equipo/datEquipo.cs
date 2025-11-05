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
                        cmd.Parameters.AddWithValue("@numero_serie", (object)equipo.numero_serie ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@marca", (object)equipo.marca ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@modelo", (object)equipo.modelo ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@anio_fabricacion", (object)equipo.anio_fabricacion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@horometro_inicial", (object)equipo.horometro_inicial ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@horometro_actual", (object)equipo.horometro_actual ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@id_area", (object)equipo.id_area ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@criticidad", equipo.criticidad ?? "MEDIA");
                        cmd.Parameters.AddWithValue("@estado", equipo.estado ?? "OPERATIVO");
                        cmd.Parameters.AddWithValue("@tipo_equipo", (object)equipo.tipo_equipo ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@activo", equipo.activo);


                        cn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            equipo.id_equipo = Convert.ToInt32(result);
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
            }

            return equipo;
        }
        /// <summary>
        /// busca equipos en la base de datos según los criterios proporcionados.
        /// </summary>
        /// <param name="codigo_flota"></param>
        /// <param name="modelo"></param>
        /// <param name="numero_serie"></param>
        /// <param name="anio_fabricacion"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<entEquipo> BuscarEquipos(string codigo_flota, string modelo,
                                    string numero_serie, int? anio_fabricacion)
        {
            List<entEquipo> lista = new List<entEquipo>();

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_BuscarEquipos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros para el SP
                    cmd.Parameters.AddWithValue("@CodigoFlota",
                        string.IsNullOrEmpty(codigo_flota) ? (object)DBNull.Value : codigo_flota);
                    cmd.Parameters.AddWithValue("@Modelo",
                        string.IsNullOrEmpty(modelo) ? (object)DBNull.Value : modelo);
                    cmd.Parameters.AddWithValue("@NumeroSerie",
                        string.IsNullOrEmpty(numero_serie) ? (object)DBNull.Value : numero_serie);
                    cmd.Parameters.AddWithValue("@AnioFabricacion",
                        anio_fabricacion.HasValue ? (object)anio_fabricacion.Value : (object)DBNull.Value);

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        entEquipo equipo = new entEquipo
                        {
                            id_equipo = dr["id_equipo"] == DBNull.Value ? 0 : Convert.ToInt32(dr["id_equipo"]),
                            codigo_flota = dr["codigo_flota"] == DBNull.Value ? "" : dr["codigo_flota"].ToString(),
                            numero_serie = dr["numero_serie"] == DBNull.Value ? "" : dr["numero_serie"].ToString(),
                            horometro_inicial = dr["horometro_inicial"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["horometro_inicial"]),
                            horometro_actual = dr["horometro_actual"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["horometro_actual"]),
                            marca = dr["marca"] == DBNull.Value ? "" : dr["marca"].ToString(),
                            modelo = dr["modelo"] == DBNull.Value ? "" : dr["modelo"].ToString(),
                            anio_fabricacion = dr["anio_fabricacion"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["anio_fabricacion"]),
                            id_area = dr["id_area"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["id_area"]),
                            criticidad = dr["criticidad"] == DBNull.Value ? "MEDIA" : dr["criticidad"].ToString(),
                            estado = dr["estado"] == DBNull.Value ? "OPERATIVO" : dr["estado"].ToString(),
                            fecha_ingreso = dr["fecha_ingreso"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_ingreso"]),
                            tipo_equipo = dr["tipo_equipo"] == DBNull.Value ? "" : dr["tipo_equipo"].ToString(),
                            activo = dr["activo"] != DBNull.Value && Convert.ToBoolean(dr["activo"])
                        };

                        lista.Add(equipo);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar equipos desde la capa de datos: " + ex.Message, ex);
                }
            }

            return lista;
        }

        public entEquipo BuscarEquipoPorCodigoFlota(string codigoFlota)
        {
            entEquipo equipo = null;

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerEquipoPorCodigoFlota", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoFlota", codigoFlota);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    equipo = new entEquipo
                    {
                        id_equipo = Convert.ToInt32(dr["IdEquipo"]),
                        codigo_flota = dr["CodigoFlota"].ToString(),
                        numero_serie = dr["NumeroSerie"].ToString(),
                        horometro_inicial = dr["HorometroInicial"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["HorometroInicial"]),
                        horometro_actual = dr["HorometroActual"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["HorometroActual"]),
                        marca = dr["Marca"].ToString(),
                        modelo = dr["Modelo"].ToString(),
                        anio_fabricacion = dr["AnioFabricacion"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["AnioFabricacion"]),
                        id_area = dr["IdArea"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["IdArea"]),
                        criticidad = dr["Criticidad"].ToString(),
                        estado = dr["Estado"].ToString(),
                        fecha_ingreso = dr["FechaIngreso"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["FechaIngreso"]),
                        tipo_equipo = dr["TipoEquipo"].ToString(),
                        activo = Convert.ToBoolean(dr["Activo"])
                    };
                }
            }

            return equipo;
        }






        /// Actualiza un equipo existente en la base de datos y registra el cambio en la bitácora.
        /*
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
        public bool dar_baja_equipo(int id_equipo)
        {
            string query = "UPDATE Equipo SET estado = 0 WHERE id_equipo = @id_equipo";
            using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id_equipo", SqlDbType.Int).Value = id_equipo;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;

                }
                ;
            };
        }
        */




        #endregion

    }
}
