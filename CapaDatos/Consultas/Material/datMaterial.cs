using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad.Material;
using CapaDatos.ConexionDB;

namespace CapaDatos.Consultas.Material
{
    public class datMaterial
    {
        private static readonly datMaterial _instancia = new datMaterial();
        public static datMaterial Instancia => _instancia;
        private datMaterial() { }

        public List<entMaterial> ListarMateriales()
        {
            SqlCommand cmd = null;
            List<entMaterial> lista = new List<entMaterial>();

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    cmd = new SqlCommand("sp_ListarMateriales", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        entMaterial m = new entMaterial
                        {
                            IdMaterial = Convert.ToInt32(dr["IdMaterial"]),
                            CodigoMaterial = dr["CodigoMaterial"].ToString(),
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),

                            IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                            IdClasificacion = dr["IdClasificacion"] != DBNull.Value ? Convert.ToInt32(dr["IdClasificacion"]) : (int?)null,
                            IdUnidad = Convert.ToInt32(dr["IdUnidad"]),

                            StockActual = Convert.ToDecimal(dr["StockActual"]),
                            StockMinimo = Convert.ToDecimal(dr["StockMinimo"]),
                            StockMaximo = dr["StockMaximo"] != DBNull.Value ? Convert.ToDecimal(dr["StockMaximo"]) : (decimal?)null,

                            PrecioPromedio = dr["PrecioPromedio"] != DBNull.Value ? Convert.ToDecimal(dr["PrecioPromedio"]) : (decimal?)null,
                            UltimoCosto = dr["UltimoCosto"] != DBNull.Value ? Convert.ToDecimal(dr["UltimoCosto"]) : (decimal?)null,

                            Activo = Convert.ToBoolean(dr["Activo"]),
                            Criticidad = dr["Criticidad"].ToString(),
                            CreadoEn = Convert.ToDateTime(dr["CreadoEn"]),

                            NombreCategoria = dr["NombreCategoria"].ToString(),
                            NombreClasificacion = dr["NombreClasificacion"].ToString(),
                            NombreUnidad = dr["NombreUnidad"].ToString()
                        };

                        lista.Add(m);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar materiales: " + ex.Message);
            }

            return lista;
        }


        public bool RegistrarMaterial(entMaterial material)
        {
            SqlCommand cmd = null;
            bool registrado = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    cmd = new SqlCommand("sp_RegistrarMaterial", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CodigoMaterial", material.CodigoMaterial);
                    cmd.Parameters.AddWithValue("@Nombre", material.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", material.Descripcion);
                    cmd.Parameters.AddWithValue("@IdCategoria", material.IdCategoria);
                    cmd.Parameters.AddWithValue("@IdClasificacion", material.IdClasificacion);
                    cmd.Parameters.AddWithValue("@IdUnidad", material.IdUnidad);
                    cmd.Parameters.AddWithValue("@StockActual", material.StockActual);
                    cmd.Parameters.AddWithValue("@StockMinimo", material.StockMinimo);
                    cmd.Parameters.AddWithValue("@StockMaximo", material.StockMaximo);
                    cmd.Parameters.AddWithValue("@PrecioPromedio", material.PrecioPromedio);
                    cmd.Parameters.AddWithValue("@UltimoCosto", material.UltimoCosto);
                    cmd.Parameters.AddWithValue("@Criticidad", material.Criticidad);


                    cn.Open();
                    registrado = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar material: " + ex.Message);
            }

            return registrado;
        }

        public bool ActualizarMaterial(entMaterial material)
        {
            SqlCommand cmd = null;
            bool actualizado = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    cmd = new SqlCommand("sp_ActualizarMaterial", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdMaterial", material.IdMaterial);
                    cmd.Parameters.AddWithValue("@CodigoMaterial", material.CodigoMaterial);
                    cmd.Parameters.AddWithValue("@Nombre", material.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)material.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdCategoria", material.IdCategoria);
                    cmd.Parameters.AddWithValue("@IdClasificacion", (object)material.IdClasificacion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdUnidad", material.IdUnidad);
                    cmd.Parameters.AddWithValue("@StockActual", material.StockActual);
                    cmd.Parameters.AddWithValue("@StockMinimo", material.StockMinimo);
                    cmd.Parameters.AddWithValue("@StockMaximo", (object)material.StockMaximo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrecioPromedio", (object)material.PrecioPromedio ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@UltimoCosto", (object)material.UltimoCosto ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Activo", material.Activo);
                    cmd.Parameters.AddWithValue("@Criticidad", material.Criticidad);

                    cn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    actualizado = true; // Lo marcamos como exitoso aunque SET NOCOUNT esté activo
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar material: " + ex.Message);
            }

            return actualizado;
        }

        public void DeshabilitarMaterial(int idMaterial)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar();
                cmd = new SqlCommand("sp_EliminarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_material", idMaterial);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deshabilitar material: " + ex.Message);
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
        }

        public bool EliminarMaterial(int idMaterial)
        {
            SqlCommand cmd = null;
            bool eliminado = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    cmd = new SqlCommand("sp_EliminarMaterial", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_material", idMaterial);
                    cn.Open();
                    eliminado = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar material: " + ex.Message);
            }

            return eliminado;
        }

        public entMaterial BuscarMaterial(string criterio)
        {
            SqlCommand cmd = null;
            entMaterial material = null;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    cmd = new SqlCommand("sp_BuscarMaterial", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@criterio", criterio);
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        material = new entMaterial
                        {
                            IdMaterial = Convert.ToInt32(dr["id_material"]),
                            CodigoMaterial = dr["codigo_material"].ToString(),
                            Nombre = dr["nombre"].ToString(),
                            Descripcion = dr["descripcion"].ToString(),
                            IdCategoria = Convert.ToInt32(dr["id_categoria"]),
                            IdUnidad = Convert.ToInt32(dr["id_unidad"]),
                            Activo = Convert.ToBoolean(dr["activo"])
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar material: " + ex.Message);
            }

            return material;
        }

        public List<entCategoriaMaterial> ListarCategorias()
        {
            List<entCategoriaMaterial> lista = new List<entCategoriaMaterial>();
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    cmd = new SqlCommand("SELECT id_categoria, nombre FROM CategoriaMaterial", cn);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new entCategoriaMaterial
                        {
                            IdCategoria = Convert.ToInt32(dr["id_categoria"]),
                            NombreCategoria = dr["nombre"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar categorías: " + ex.Message);
            }

            return lista;
        }

        public List<entUnidadMedida> ListarUnidades()
        {
            List<entUnidadMedida> lista = new List<entUnidadMedida>();
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    cmd = new SqlCommand("SELECT id_unidad, descripcion FROM UnidadMedida", cn);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new entUnidadMedida
                        {
                            IdUnidad = Convert.ToInt32(dr["id_unidad"]),
                            NombreUnidad = dr["descripcion"].ToString()
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

        public List<entClasificacionMaterial> ListarClasificaciones()
        {
            List<entClasificacionMaterial> lista = new List<entClasificacionMaterial>();
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    cmd = new SqlCommand("SELECT id_clasificacion, nombre FROM ClasificacionMaterial", cn);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new entClasificacionMaterial
                        {
                            IdClasificacion = Convert.ToInt32(dr["id_clasificacion"]),
                            NombreClasificacion = dr["nombre"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar clasificaciones: " + ex.Message);
            }

            return lista;
        }
    }
}
