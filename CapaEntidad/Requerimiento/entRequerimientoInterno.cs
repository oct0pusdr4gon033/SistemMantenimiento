using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Requerimiento
{
    public class entRequerimientoInterno
    {
        public int id_req { get; set; }
        public int id_empleado { get; set; }
        public string cod_req { get; set; }
        public DateTime fech_req { get; set; }
    }
}
