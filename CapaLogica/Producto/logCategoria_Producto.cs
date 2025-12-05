using System;
using System.Collections.Generic;
using CapaDatos.Consultas.Material;
using CapaEntidad.Producto;

namespace CapaLogica.Producto
{
    public class logCategoria_Producto
    {
        private static readonly logCategoria_Producto _instancia = new logCategoria_Producto();
        public static logCategoria_Producto Instancia => _instancia;

        // LISTAR TODAS LAS CATEGORÍAS
        public List<entCategoria_Producto> ListarCategorias()
        {
            return datCategoria_Producto.Instancia.ListarCategorias();
        }

        // REGISTRAR CATEGORÍA
        public bool RegistrarCategoria(entCategoria_Producto cat)
        {
            if (string.IsNullOrWhiteSpace(cat.nombre_categoria))
                throw new ApplicationException("Debe ingresar un nombre de categoría");

            return datCategoria_Producto.Instancia.RegistrarCategoria(cat);
        }

        // ACTUALIZAR CATEGORÍA
        public bool ActualizarCategoria(entCategoria_Producto cat)
        {
            if (cat.id_categoria <= 0)
                throw new ApplicationException("ID no válido para actualizar");

            if (string.IsNullOrWhiteSpace(cat.nombre_categoria))
                throw new ApplicationException("Debe ingresar un nombre para actualizar");

            return datCategoria_Producto.Instancia.ActualizarCategoria(cat);
        }

        // ELIMINAR CATEGORÍA
        public bool EliminarCategoria(int id)
        {
            if (id <= 0)
                throw new ApplicationException("Debe seleccionar una categoría válida para eliminar");

            return datCategoria_Producto.Instancia.EliminarCategoria(id);
        }
    }
}
