using CapaDatos.Consultas;
using CapaEntidad;
using CapaEntidad.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaLogica
{
    public class logEmpleado
    {
        private static readonly logEmpleado _instancia = new logEmpleado();
        public static logEmpleado Instancia => _instancia;

        public List<entEmpleado> Listar()
        {
            return datEmpleado.Instancia.Listar();
        }

        public string Registrar(entEmpleado e)
        {
            if (string.IsNullOrWhiteSpace(e.dni_empleado))
                return "Debe ingresar un DNI.";

            if (e.id_cargo <= 0)
                return "Debe seleccionar un cargo.";

            if (string.IsNullOrWhiteSpace(e.nombre_empleado))
                return "Debe ingresar un nombre.";

            if (string.IsNullOrWhiteSpace(e.apellido_empleado))
                return "Debe ingresar un apellido.";

            datEmpleado.Instancia.Insertar(e);
            return "Empleado registrado correctamente.";
        }

        public string Editar(entEmpleado e)
        {
            if (e.id_empleado <= 0)
                return "Seleccione un empleado válido.";

            if (string.IsNullOrWhiteSpace(e.nombre_empleado))
                return "Debe ingresar un nombre.";

            datEmpleado.Instancia.Editar(e);
            return "Empleado actualizado correctamente.";
        }

    }
}
