using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Requerimiento
{
    public class entDetReqInt
    {
        public int id_detalle { get; set; }
        public int id_requerimiento { get; set; }
        public int id_material { get; set; }
        public decimal cantidad { get; set; }

        // Info adicional opcional (por si la necesitas en pantalla)
        public string nombre_material { get; set; }
        public string unidad_abreviatura { get; set; }
    }
}
