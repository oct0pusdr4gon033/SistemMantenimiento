using System;
using System.Collections.Generic;
using CapaDatos.Consultas.Producto;
using CapaEntidad.Producto;

namespace CapaLogica.Producto
{
    public class logCategoria_Producto
    {
        private static readonly logCategoria_Producto _instancia = new logCategoria_Producto();
        public static logCategoria_Producto Instancia => _instancia;

        private logCategoria_Producto() { }

        #region Métodos Lógicos

        public List<entCategoria_Producto> ListarCategorias()
        {
            try
            {
                return datCategoria_Producto.Instancia.ListarCategorias();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al listar categorías.", ex);
            }
        }

        public bool RegistrarCategoria(entCategoria_Producto categoria)
        {
            try
            {
                if (categoria == null)
                    throw new ArgumentNullException(nameof(categoria), "La categoría no puede ser nula");

                if (string.IsNullOrWhiteSpace(categoria.nombre_categoria))
                    throw new ApplicationException("Debe ingresar un nombre de categoría");

                return datCategoria_Producto.Instancia.RegistrarCategoria(categoria);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al registrar la categoría.", ex);
            }
        }

        public bool ActualizarCategoria(entCategoria_Producto categoria)
        {
            try
            {
                if (categoria == null)
                    throw new ArgumentNullException(nameof(categoria), "La categoría no puede ser nula");

                if (categoria.id_categoria <= 0)
                    throw new ApplicationException("ID inválido para actualizar");

                if (string.IsNullOrWhiteSpace(categoria.nombre_categoria))
                    throw new ApplicationException("Debe ingresar un nombre válido");

                return datCategoria_Producto.Instancia.ActualizarCategoria(categoria);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al actualizar la categoría.", ex);
            }
        }

        public bool EliminarCategoria(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ApplicationException("Debe seleccionar una categoría válida para eliminar");

                return datCategoria_Producto.Instancia.EliminarCategoria(id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar la categoría.", ex);
            }
        }

        #endregion
    }
}
