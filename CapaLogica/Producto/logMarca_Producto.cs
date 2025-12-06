using System;
using System.Collections.Generic;
using CapaEntidad.Producto;
using CapaDatos.Consultas.Producto;

namespace CapaLogica.Producto
{
    public class logMarca_Producto
    {
        private static readonly logMarca_Producto _instancia = new logMarca_Producto();
        public static logMarca_Producto Instancia => _instancia;

        private logMarca_Producto() { }

        // LISTAR
        public List<entMarca_Producto> ListarMarcas()
        {
            return datMarca_Producto.Instancia.ListarMarcas();
        }

        // REGISTRAR
        public bool RegistrarMarca(entMarca_Producto marca)
        {
            if (marca == null)
                throw new ApplicationException("La marca enviada es inválida.");

            if (string.IsNullOrWhiteSpace(marca.nombre_marca))
                throw new ApplicationException("Debe ingresar un nombre de marca.");

            return datMarca_Producto.Instancia.RegistrarMarca(marca);
        }

        // ACTUALIZAR
        public bool ActualizarMarca(entMarca_Producto marca)
        {
            if (marca == null || marca.id_marca <= 0)
                throw new ApplicationException("Debe seleccionar una marca válida para actualizar.");

            if (string.IsNullOrWhiteSpace(marca.nombre_marca))
                throw new ApplicationException("Debe ingresar un nombre para actualizar.");

            return datMarca_Producto.Instancia.ActualizarMarca(marca);
        }

        // ELIMINAR
        public bool EliminarMarca(int id)
        {
            if (id <= 0)
                throw new ApplicationException("Debe seleccionar una marca válida para eliminar.");

            return datMarca_Producto.Instancia.EliminarMarca(id);
        }
    }
}
