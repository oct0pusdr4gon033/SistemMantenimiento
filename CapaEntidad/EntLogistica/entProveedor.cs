using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.EntLogistica
{
    public class entProveedor
    {
        public string ruc { get; set; }
        public string razon_social { get; set; }
        public string tipo_proveedor { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public string contacto_nombre { get; set; }
        public string contacto_telefono { get; set; }
        public int dias_credito { get; set; }
        public bool activo { get; set; }
        public DateTime creado_en { get; set; }
    }
}
