using System;
using System.Collections.Generic;
using CapaEntidad.Producto;
using CapaDatos.Consultas.Material;

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
        public bool RegistrarMarca(entMarca_Producto m)
        {
            if (string.IsNullOrWhiteSpace(m.nombre_marca))
                throw new Exception("El nombre de la marca no puede estar vacío 😑");

            return datMarca_Producto.Instancia.RegistrarMarca(m);
        }

        // ACTUALIZAR
        public bool ActualizarMarca(entMarca_Producto m)
        {
            if (m.id_marca <= 0)
                throw new Exception("Selecciona una marca válida para editar 😐");

            if (string.IsNullOrWhiteSpace(m.nombre_marca))
                throw new Exception("El nombre de la marca no puede estar vacío 😑");

            return datMarca_Producto.Instancia.ActualizarMarca(m);
        }

        // ELIMINAR
        public bool EliminarMarca(int id)
        {
            if (id <= 0)
                throw new Exception("Selecciona una marca válida para eliminar 🤦‍♂️");

            return datMarca_Producto.Instancia.EliminarMarca(id);
        }
    }
}
