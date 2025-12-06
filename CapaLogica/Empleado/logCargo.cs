using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Consultas;
using CapaDatos.ConsultasEmpleado;
using CapaEntidad;
using CapaEntidad.Empleado;

namespace CapaLogica.Empleado
{
    public class logCargo
    {
        private static readonly logCargo _instancia = new logCargo();
        public static logCargo Instancia => _instancia;

        // LISTAR
        public List<entCargo> Listar()
        {
            try
            {
                return datCargo.Instancia.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar cargos: " + ex.Message);
            }
        }

        // INSERTAR
        public string Insertar(entCargo cargo)
        {
            if (string.IsNullOrWhiteSpace(cargo.nombre_cargo))
                return "Debe ingresar un nombre de cargo válido.";

            bool ok = datCargo.Instancia.Insertar(cargo);
            return ok ? "Cargo registrado correctamente." : "No se pudo registrar el cargo.";
        }

        // EDITAR
        public string Editar(entCargo cargo)
        {
            if (cargo.id_cargo <= 0)
                return "Seleccione un cargo válido.";

            if (string.IsNullOrWhiteSpace(cargo.nombre_cargo))
                return "Debe ingresar un nombre válido.";

            bool ok = datCargo.Instancia.Editar(cargo);
            return ok ? "Cargo actualizado correctamente." : "No se pudo actualizar el cargo.";
        }

        // ELIMINAR
        public string Eliminar(int idCargo)
        {
            if (idCargo <= 0)
                return "Seleccione un cargo válido.";

            bool ok = datCargo.Instancia.Eliminar(idCargo);
            return ok ? "Cargo eliminado correctamente." : "No se pudo eliminar el cargo.";
        }
    }
}
