using System;
using System.Collections.Generic;
using CapaDatos.Consultas.Producto;
using CapaEntidad.Producto;

namespace CapaLogica.Producto
{
    public class logProducto
    {
        private static readonly logProducto _instancia = new logProducto();
        public static logProducto Instancia => _instancia;

        private logProducto() { }

        // LISTAR PRODUCTOS
        public List<entProducto> ListarProductos()
        {
            try
            {
                return datProducto.Instancia.ListarProductos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos: " + ex.Message);
            }
        }

        // REGISTRAR PRODUCTO
        public string RegistrarProducto(entProducto prod)
        {
            if (string.IsNullOrWhiteSpace(prod.codigo_producto))
                return "Debe ingresar un código válido.";

            if (string.IsNullOrWhiteSpace(prod.nombre))
                return "Debe ingresar un nombre válido.";

            if (prod.id_marca <= 0)
                return "Debe seleccionar una marca válida.";

            if (prod.id_unidad <= 0)
                return "Debe seleccionar una unidad válida.";

            if (prod.id_categoria <= 0)
                return "Debe seleccionar una categoría válida.";

            if (prod.stock_actual < 0)
                return "El stock actual no puede ser negativo.";

            bool ok = datProducto.Instancia.RegistrarProducto(prod);
            return ok ? "Producto registrado correctamente." : "No se pudo registrar el producto.";
        }

        // ACTUALIZAR PRODUCTO
        public string ActualizarProducto(entProducto prod)
        {
            if (prod.id_producto <= 0)
                return "Seleccione un producto válido.";

            if (string.IsNullOrWhiteSpace(prod.nombre))
                return "Debe ingresar un nombre válido.";

            if (prod.id_categoria <= 0)
                return "Debe seleccionar una categoría válida.";

            bool ok = datProducto.Instancia.ActualizarProducto(prod);
            return ok ? "Producto actualizado correctamente." : "No se pudo actualizar el producto.";
        }

        // ELIMINAR PRODUCTO
        public string EliminarProducto(int id_producto)
        {
            if (id_producto <= 0)
                return "Seleccione un producto válido.";

            bool ok = datProducto.Instancia.EliminarProducto(id_producto);
            return ok ? "Producto eliminado correctamente." : "No se pudo eliminar el producto.";
        }
        public bool DescontarStock(int idProducto, decimal cantidad)
        {
            return datProducto.Instancia.DescontarStock(idProducto, cantidad);
        }

        public entProducto BuscarPorId(int idProducto)
        {
            return datProducto.Instancia.BuscarPorId(idProducto);
        }


    }
}
