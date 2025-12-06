using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Empleado
{
    public class entEmpleado
    {
        public int id_empleado { get; set; }
        public string dni_empleado { get; set; }
        public int id_cargo { get; set; }
        public string nombre_empleado { get; set; }
        public string apellido_empleado { get; set; }
        public string telf { get; set; }
        public string correo { get; set; }
    }
}
