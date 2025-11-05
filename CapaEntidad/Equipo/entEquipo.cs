using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Equipo
{
    public class entEquipo
    {
        public int id_equipo { get; set; }
        public string codigo_flota { get; set; }
        public string numero_serie { get; set; }
        public decimal? horometro_inicial { get; set; }
        public decimal? horometro_actual { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int? anio_fabricacion { get; set; }
        public int? id_area { get; set; }
        public string criticidad { get; set; } 
        public string estado { get; set; }  // VARCHAR ahora
        public DateTime? fecha_ingreso { get; set; } = DateTime.UtcNow;
        public string tipo_equipo { get; set; }
        public bool activo { get; set; } 
    }
}
