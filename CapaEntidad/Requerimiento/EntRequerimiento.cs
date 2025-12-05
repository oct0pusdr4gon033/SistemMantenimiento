using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Requerimiento
{
    public class EntRequerimiento
    {
        // Mapeo de la tabla Requerimiento_Interno
        public int IdReq { get; set; }
        public int IdEmpleado { get; set; }
        public string CodReq { get; set; }
        public string FechaReq { get; set; } // Puedes usar string o DateTime según prefieras

        // ESTA ES LA CLAVE: Una lista que contiene los detalles.
        // Esto permite pasar el maestro y sus detalles en un solo objeto.
        public List<EntDetalleRequerimiento> ListaDetalles { get; set; }

        // Constructor para inicializar la lista y evitar errores de "null"
        public EntRequerimiento()
        {
            this.ListaDetalles = new List<EntDetalleRequerimiento>();
        }
    }
}
