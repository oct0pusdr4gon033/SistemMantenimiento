using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Consultas.Producto;
using CapaEntidad.Producto;

namespace CapaLogica.Producto
{
    public class logUnidadMedida_Producto
    {
        private static readonly logUnidadMedida_Producto _instancia = new logUnidadMedida_Producto();
        public static logUnidadMedida_Producto Instancia => _instancia;

        // LISTAR
        public List<entUnidadMedida_Producto> ListarUnidades()
        {
            return datUnidadMedida_Producto.Instancia.ListarUnidades();
        }

        // REGISTRAR
        public string RegistrarUnidad(entUnidadMedida_Producto unidad)
        {
            if (string.IsNullOrWhiteSpace(unidad.nombre_unidad))
                return "El nombre de la unidad no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(unidad.abreviatura))
                return "La abreviatura es obligatoria.";

            bool ok = datUnidadMedida_Producto.Instancia.RegistrarUnidad(unidad);
            return ok ? "Unidad registrada correctamente." : "No se pudo registrar la unidad.";
        }

        // ACTUALIZAR
        public string ActualizarUnidad(entUnidadMedida_Producto unidad)
        {
            if (unidad.id_unidad <= 0)
                return "Debe seleccionar una unidad válida.";

            if (string.IsNullOrWhiteSpace(unidad.nombre_unidad))
                return "El nombre de la unidad no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(unidad.abreviatura))
                return "La abreviatura es obligatoria.";

            bool ok = datUnidadMedida_Producto.Instancia.ActualizarUnidad(unidad);
            return ok ? "Unidad actualizada correctamente." : "No se pudo actualizar la unidad.";
        }

        // ELIMINAR
        public string EliminarUnidad(int id_unidad)
        {
            if (id_unidad <= 0)
                return "Debe seleccionar una unidad.";

            bool ok = datUnidadMedida_Producto.Instancia.EliminarUnidad(id_unidad);
            return ok ? "Unidad eliminada correctamente." : "No se pudo eliminar la unidad.";
        }
    }
}
