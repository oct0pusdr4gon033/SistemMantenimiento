using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Equipo
{
    public class entEquipo
    {
        public string codigo_flota { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string num_serie { get; set; }
        public string tipo_equipo { get; set; }
        public int anio_fabricacion { get; set; }
        public int horometro_inicial { get; set; }
        public int horometro_actual { get; set; }
        public DateTime fecha_compra { get; set; }
        public DateTime fecha_registro { get; set; }

        public bool estado_equipo { get; set; }

    }
}
