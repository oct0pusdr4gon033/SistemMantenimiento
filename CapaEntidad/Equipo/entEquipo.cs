using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Equipo
{
    public class entEquipo
    {
        public int id_equipo { get; set; }
        public int id_area { get; set;  }
        public int id_tipo_equipo { get; set; } 
        public int id_modelo_equipo { get; set; }
        public string codigo_flota { get; set; }
        public string nume_serie { get; set; }
        public int anio_fabricacion { get; set;  }
        public  double horometro_compra { get; set; }
        public double horometro_ingreso { get; set;  }
        public DateTime fecha_ingreso { get; set; }
        public string estado { get; set; }
        public string nombre_area { get; set; }
        public string nombre_tipo_equipo { get; set; }
        public string nombre_modelo { get; set; }
        public string nombre_marca { get; set; }
    }
}
