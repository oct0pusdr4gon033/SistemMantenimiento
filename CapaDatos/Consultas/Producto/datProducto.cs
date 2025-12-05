using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad.Producto;
using CapaDatos.ConexionDB;

namespace CapaDatos.Consultas.Material
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
                {
                    SqlCommand cmd = new SqlCommand(@"
                        SELECT 
                            p.id_producto,
                            p.codigo_producto,
                            p.nombre,
                            p.id_marca, m.nombre_marca,
                            p.id_unidad, u.abreviatura,
                            p.id_categoria, c.nombre_categoria,
                            p.stock_actual,
                            p.stock_minimo
                        FROM Producto p
                        INNER JOIN Marca m ON p.id_marca = m.id_marca
                        INNER JOIN Unidad_Medida u ON p.id_unidad = u.id_unidad
                        INNER JOIN Categoria c ON p.id_categoria = c.id_categoria", cn);

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
                            id_unidad = Convert.ToInt32(dr["id_unidad"]),
                            id_categoria = Convert.ToInt32(dr["id_categoria"]),
                            stock_actual = Convert.ToDecimal(dr["stock_actual"]),
                            stock_minimo = Convert.ToSingle(dr["stock_minimo"]),
                            nombre_marca = dr["nombre_marca"].ToString(),
                            unidad_abreviatura = dr["abreviatura"].ToString(),
                            nombre_categoria = dr["nombre_categoria"].ToString()
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
            bool ok = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO Producto(codigo_producto, nombre, id_categoria, id_unidad, id_marca, stock_actual, stock_minimo)
                        VALUES (@codigo, @nombre, @categoria, @unidad, @marca, @stockA, @stockM)", cn);

                    cmd.Parameters.AddWithValue("@codigo", mat.codigo_producto);
                    cmd.Parameters.AddWithValue("@nombre", mat.nombre);
                    cmd.Parameters.AddWithValue("@categoria", mat.id_categoria);
                    cmd.Parameters.AddWithValue("@unidad", mat.id_unidad);
                    cmd.Parameters.AddWithValue("@marca", mat.id_marca);
                    cmd.Parameters.AddWithValue("@stockA", mat.stock_actual);
                    cmd.Parameters.AddWithValue("@stockM", mat.stock_minimo);

                    cn.Open();
                    ok = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar producto: " + ex.Message);
            }

            return ok;
        }

        // ACTUALIZAR PRODUCTO
        public bool ActualizarProducto(entProducto mat)
        {
            bool ok = false;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(@"
                        UPDATE Producto SET
                            codigo_producto=@codigo,
                            nombre=@nombre,
                            id_categoria=@categoria,
                            id_unidad=@unidad,
                            id_marca=@marca,
                            stock_actual=@stockA,
                            stock_minimo=@stockM
                        WHERE id_producto=@id", cn);

                    cmd.Parameters.AddWithValue("@id", mat.id_producto);
                    cmd.Parameters.AddWithValue("@codigo", mat.codigo_producto);
                    cmd.Parameters.AddWithValue("@nombre", mat.nombre);
                    cmd.Parameters.AddWithValue("@categoria", mat.id_categoria);
                    cmd.Parameters.AddWithValue("@unidad", mat.id_unidad);
                    cmd.Parameters.AddWithValue("@marca", mat.id_marca);
                    cmd.Parameters.AddWithValue("@stockA", mat.stock_actual);
                    cmd.Parameters.AddWithValue("@stockM", mat.stock_minimo);

                    cn.Open();
                    ok = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar producto: " + ex.Message);
            }

            return ok;
        }

        // COMBOS
        public List<entMarca_Producto> ListarMarcas()
        {
            List<entMarca_Producto> lista = new List<entMarca_Producto>();

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Marca", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new entMarca_Producto
                    {
                        id_marca = (int)dr["id_marca"],
                        nombre_marca = dr["nombre_marca"].ToString()
                    });
                }
            }
            return lista;
        }

        public List<entUnidadMedida_Producto> ListarUnidades()
        {
            List<entUnidadMedida_Producto> lista = new List<entUnidadMedida_Producto>();

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Unidad_Medida", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new entUnidadMedida_Producto
                    {
                        id_unidad = (int)dr["id_unidad"],
                        nombre_unidad = dr["nombre_unidad"].ToString(),
                        abreviatura = dr["abreviatura"].ToString()
                    });
                }
            }
            return lista;
        }

        public List<entCategoria_Producto> ListarCategorias()
        {
            List<entCategoria_Producto> lista = new List<entCategoria_Producto>();

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Categoria", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new entCategoria_Producto
                    {
                        id_categoria = (int)dr["id_categoria"],
                        nombre_categoria = dr["nombre_categoria"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}