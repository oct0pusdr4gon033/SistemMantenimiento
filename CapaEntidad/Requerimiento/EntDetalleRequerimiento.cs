using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Requerimiento
{
    public class EntDetalleRequerimiento
    {

        public int IdDetReq { get; set; }
        public int IdReq { get; set; }
        public int IdProducto { get; set; }
        public decimal StockSolicitado { get; set; }
    }
}
