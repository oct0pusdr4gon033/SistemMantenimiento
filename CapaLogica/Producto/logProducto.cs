using System;
using System.Collections.Generic;
using CapaDatos.Consultas.Material;
using CapaEntidad.Producto;

namespace CapaLogica.Producto
{
    public class logProducto
    {
        private static readonly logProducto _instancia = new logProducto();
        public static logProducto Instancia => _instancia;

        private logProducto() { }

        // ==============================
        // LISTAR PRODUCTOS
        // ==============================
        public List<entProducto> ListarProductos()
        {
            try
            {
                return datProducto.Instancia.ListarMateriales();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos: " + ex.Message);
            }
        }

        // ==============================
        // REGISTRAR PRODUCTO
        // ==============================
        public bool RegistrarProducto(entProducto prod)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(prod.codigo_producto))
                    throw new ArgumentException("Debe ingresar un código.");

                if (string.IsNullOrWhiteSpace(prod.nombre))
                    throw new ArgumentException("Debe ingresar un nombre.");

                if (prod.id_marca <= 0)
                    throw new ArgumentException("Seleccione una marca.");

                if (prod.id_unidad <= 0)
                    throw new ArgumentException("Seleccione una unidad.");

                if (prod.id_categoria <= 0)
                    throw new ArgumentException("Seleccione una categoría.");

                if (prod.stock_actual < 0)
                    throw new ArgumentException("El stock no puede ser negativo.");

                return datProducto.Instancia.RegistrarMaterial(prod);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar producto: " + ex.Message);
            }
        }

        // ==============================
        // ACTUALIZAR PRODUCTO
        // ==============================
        public bool ActualizarProducto(entProducto prod)
        {
            try
            {
                if (prod.id_producto <= 0)
                    throw new ArgumentException("ID de producto inválido.");

                if (prod.id_categoria <= 0)
                    throw new ArgumentException("Seleccione una categoría.");

                return datProducto.Instancia.ActualizarMaterial(prod);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar producto: " + ex.Message);
            }
        }

        // ==============================
        // COMBOS
        // ==============================
        public List<entMarca_Producto> ListarMarcas()
        {
            try
            {
                return datProducto.Instancia.ListarMarcas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar marcas: " + ex.Message);
            }
        }

        public List<entUnidadMedida> ListarUnidades()
        {
            try
            {
                return datProducto.Instancia.ListarUnidades();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar unidades: " + ex.Message);
            }
        }

        public List<entCategoria_Producto> ListarCategorias()
        {
            try
            {
                return datProducto.Instancia.ListarCategorias();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar categorías: " + ex.Message);
            }
        }
    }
}
