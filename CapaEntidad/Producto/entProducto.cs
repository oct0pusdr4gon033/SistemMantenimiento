using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Producto
{
    public class entProducto
    {
        public int id_producto { get; set; }
        public string codigo_producto { get; set; }
        public string nombre { get; set; }

        public int id_marca { get; set; }
        public int id_unidad { get; set; }
        public int id_categoria { get; set; }

        public decimal stock_actual { get; set; }
        public float stock_minimo { get; set; }

        public string nombre_marca { get; set; }
        public string unidad_abreviatura { get; set; }
        public string nombre_categoria { get; set; }
    }
}
