using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad.Producto;
using CapaDatos.ConexionDB;
using System.Data;

namespace CapaDatos.Consultas.Producto
{
    public class datProducto
    {
        private static readonly datProducto _instancia = new datProducto();
        public static datProducto Instancia => _instancia;

        private datProducto() { }

        // LISTAR PRODUCTOS
        public List<entProducto> ListarProductos()
        {
            List<entProducto> lista = new List<entProducto>();

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_ListarProducto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(new entProducto
                        {
                            id_producto = Convert.ToInt32(dr["id_producto"]),
                            codigo_producto = dr["codigo_producto"].ToString(),
                            nombre = dr["nombre"].ToString(),
                            id_marca = Convert.ToInt32(dr["id_marca"]),
                            nombre_marca = dr["nombre_marca"].ToString(),
                            id_unidad = Convert.ToInt32(dr["id_unidad"]),
                            unidad_abreviatura = dr["abreviatura"].ToString(),
                            id_categoria = Convert.ToInt32(dr["id_categoria"]),
                            nombre_categoria = dr["nombre_categoria"].ToString(),
                            stock_actual = Convert.ToDecimal(dr["stock_actual"]),
                            stock_minimo = Convert.ToSingle(dr["stock_minimo"]) // <<< cambio correcto
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos: " + ex.Message);
            }

            return lista;
        }

        // REGISTRAR PRODUCTO
        public bool RegistrarProducto(entProducto mat)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_RegistrarProducto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@codigo_producto", mat.codigo_producto);
                    cmd.Parameters.AddWithValue("@nombre", mat.nombre);
                    cmd.Parameters.AddWithValue("@id_categoria", mat.id_categoria);
                    cmd.Parameters.AddWithValue("@id_unidad", mat.id_unidad);
                    cmd.Parameters.AddWithValue("@id_marca", mat.id_marca);
                    cmd.Parameters.AddWithValue("@stock_actual", mat.stock_actual);
                    cmd.Parameters.AddWithValue("@stock_minimo", mat.stock_minimo);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar producto: " + ex.Message);
            }
        }

        // ACTUALIZAR PRODUCTO
        public bool ActualizarProducto(entProducto mat)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_ActualizarProducto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_producto", mat.id_producto);
                    cmd.Parameters.AddWithValue("@codigo_producto", mat.codigo_producto);
                    cmd.Parameters.AddWithValue("@nombre", mat.nombre);
                    cmd.Parameters.AddWithValue("@id_categoria", mat.id_categoria);
                    cmd.Parameters.AddWithValue("@id_unidad", mat.id_unidad);
                    cmd.Parameters.AddWithValue("@id_marca", mat.id_marca);
                    cmd.Parameters.AddWithValue("@stock_actual", mat.stock_actual);
                    cmd.Parameters.AddWithValue("@stock_minimo", mat.stock_minimo);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar producto: " + ex.Message);
            }
        }

        // ELIMINAR PRODUCTO
        public bool EliminarProducto(int id_producto)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_EliminarProducto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar producto: " + ex.Message);
            }
        }
    }
}
