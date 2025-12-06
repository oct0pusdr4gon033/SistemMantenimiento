using CapaEntidad.Equipo;
using System;
using System.CodeDom;
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
        ///

        // 1. LISTAR EQUIPOS
        public List<entEquipo> ListarEquipos()
        {
            List<entEquipo> lista = new List<entEquipo>();
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarEquipos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new entEquipo()
                            {
                                id_equipo = Convert.ToInt32(dr["id_equipo"]),
                                id_area = Convert.ToInt32(dr["id_area"]),
                                nombre_area = dr["nombre_area"].ToString(),
                                id_tipo_equipo = Convert.ToInt32(dr["id_tipo_equipo"]),
                                nombre_tipo_equipo = dr["nombre_tipo_equipo"].ToString(),
                                id_modelo_equipo = Convert.ToInt32(dr["id_modelo_equipo"]),
                                nombre_modelo = dr["nombre_modelo"].ToString(),
                                nombre_marca = dr["nombre_marca"].ToString(),
                                codigo_flota = dr["codigo_flota"].ToString(),
                                nume_serie = dr["num_serie"].ToString(),
                                // Nota: En tu SQL la columna tiene un typo 'frabricacion', lo respetamos aquí
                                anio_fabricacion = Convert.ToInt32(dr["anio_frabricacion"]),
                                horometro_compra = Convert.ToDouble(dr["horometro_compra"]),
                                horometro_ingreso = Convert.ToDouble(dr["horometro_ingreso"]),
                                fecha_ingreso = Convert.ToDateTime(dr["fecha_ingreso"]),
                                estado = dr["estado"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<entEquipo>();
                    throw ex; // O manejar el error según tu política
                }
            }
            return lista;
        }

        // 2. BUSCAR EQUIPOS
        public List<entEquipo> BuscarEquipos(string texto)
        {
            List<entEquipo> lista = new List<entEquipo>();
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_BuscarEquipos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@texto", texto);

                try
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new entEquipo()
                            {
                                id_equipo = Convert.ToInt32(dr["id_equipo"]),
                                id_area = Convert.ToInt32(dr["id_area"]),
                                nombre_area = dr["nombre_area"].ToString(),
                                id_tipo_equipo = Convert.ToInt32(dr["id_tipo_equipo"]),
                                nombre_tipo_equipo = dr["nombre_tipo_equipo"].ToString(),
                                id_modelo_equipo = Convert.ToInt32(dr["id_modelo_equipo"]),
                                nombre_modelo = dr["nombre_modelo"].ToString(),
                                nombre_marca = dr["nombre_marca"].ToString(),
                                codigo_flota = dr["codigo_flota"].ToString(),
                                nume_serie = dr["num_serie"].ToString(),
                                anio_fabricacion = Convert.ToInt32(dr["anio_frabricacion"]),
                                horometro_compra = Convert.ToDouble(dr["horometro_compra"]),
                                horometro_ingreso = Convert.ToDouble(dr["horometro_ingreso"]),
                                fecha_ingreso = Convert.ToDateTime(dr["fecha_ingreso"]),
                                estado = dr["estado"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<entEquipo>();
                    throw ex;
                }
            }
            return lista;
        }

        // 3. INSERTAR EQUIPO
        public bool InsertarEquipo(entEquipo obj)
        {
            bool respuesta = false;
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarEquipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_area", obj.id_area);
                cmd.Parameters.AddWithValue("@id_tipo_equipo", obj.id_tipo_equipo);
                cmd.Parameters.AddWithValue("@id_modelo_equipo", obj.id_modelo_equipo);
                cmd.Parameters.AddWithValue("@codigo_flota", obj.codigo_flota);
                cmd.Parameters.AddWithValue("@num_serie", obj.nume_serie); // Nombre parámetro según SP Insertar
                cmd.Parameters.AddWithValue("@anio_fabricacion", obj.anio_fabricacion);
                cmd.Parameters.AddWithValue("@horometro_compra", obj.horometro_compra);
                cmd.Parameters.AddWithValue("@horometro_ingreso", obj.horometro_ingreso);
                cmd.Parameters.AddWithValue("@fecha_ingreso", obj.fecha_ingreso);
                cmd.Parameters.AddWithValue("@estado", obj.estado);

                try
                {
                    cn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0) respuesta = true;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    throw ex;
                }
            }
            return respuesta;
        }

        // 4. EDITAR EQUIPO
        public bool EditarEquipo(entEquipo obj)
        {
            bool respuesta = false;
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_EditarEquipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_equipo", obj.id_equipo);
                cmd.Parameters.AddWithValue("@id_area", obj.id_area);
                cmd.Parameters.AddWithValue("@id_tipo_equipo", obj.id_tipo_equipo);
                cmd.Parameters.AddWithValue("@id_modelo_equipo", obj.id_modelo_equipo);
                cmd.Parameters.AddWithValue("@codigo_flota", obj.codigo_flota);
                // OJO: En tu SP de Editar el parámetro se llama @numero_serie, diferente al Insertar
                cmd.Parameters.AddWithValue("@numero_serie", obj.nume_serie);
                cmd.Parameters.AddWithValue("@anio_fabricacion", obj.anio_fabricacion);
                cmd.Parameters.AddWithValue("@horometro_compra", obj.horometro_compra);
                cmd.Parameters.AddWithValue("@horometro_ingreso", obj.horometro_ingreso);
                cmd.Parameters.AddWithValue("@fecha_ingreso", obj.fecha_ingreso);
                cmd.Parameters.AddWithValue("@estado", obj.estado);

                try
                {
                    cn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0) respuesta = true;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    throw ex;
                }
            }
            return respuesta;
        }

        // 5. ELIMINAR EQUIPO
        public bool EliminarEquipo(entEquipo obj)
        {
            bool respuesta = false;
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarEquipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_equipo", obj.id_equipo);

                try
                {
                    cn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0) respuesta = true;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    throw ex;
                }
            }
            return respuesta;
        }


        ///BUSQUEDA 
        public List<entEquipo> BuscarEquipoParametros(string codigo_flota, string modelo, string marca,string area,int anio_fabricacion)
        {
            try
            {
                List<entEquipo> lista = new List<entEquipo>();

                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_BuscarEquiposParametro", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Enviar NULL si el parámetro no se usa
                        cmd.Parameters.AddWithValue("@codigo_flota",
                            string.IsNullOrEmpty(codigo_flota) ? (object)DBNull.Value : codigo_flota);

                        cmd.Parameters.AddWithValue("@modelo",
                            string.IsNullOrEmpty(modelo) ? (object)DBNull.Value : modelo);

                        cmd.Parameters.AddWithValue("@marca",
                            string.IsNullOrEmpty(marca) ? (object)DBNull.Value : marca);

                        cmd.Parameters.AddWithValue("@area",
                            string.IsNullOrEmpty(area) ? (object)DBNull.Value : area);

                        cmd.Parameters.AddWithValue("@anio_fabricacion",
                            anio_fabricacion == 0 ? (object)DBNull.Value : anio_fabricacion);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                entEquipo equipo = new entEquipo
                                {
                                    id_equipo = Convert.ToInt32(reader["id_equipo"]),
                                    id_area = Convert.ToInt32(reader["id_area"]),
                                    nombre_area = reader["nombre_area"].ToString(),

                                    id_tipo_equipo = Convert.ToInt32(reader["id_tipo_equipo"]),
                                    nombre_tipo_equipo = reader["nombre_tipo_equipo"].ToString(),

                                    id_modelo_equipo = Convert.ToInt32(reader["id_modelo_equipo"]),
                                    nombre_modelo = reader["nombre_modelo"].ToString(),

                                    nombre_marca = reader["nombre_marca"].ToString(),

                                    codigo_flota = reader["codigo_flota"].ToString(),
                                    nume_serie = reader["num_serie"].ToString(),  // ← nombre real
                                    anio_fabricacion = Convert.ToInt32(reader["anio_frabricacion"]), // ← nombre real

                                    horometro_compra = Convert.ToDouble(reader["horometro_compra"]),
                                    horometro_ingreso = Convert.ToDouble(reader["horometro_ingreso"]),

                                    fecha_ingreso = Convert.ToDateTime(reader["fecha_ingreso"]),
                                    estado = reader["estado"].ToString()
                                };

                                lista.Add(equipo);
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
