using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Equipo
{
    public class entHorometro
    {
        public int id_horometro { get; set; }
        public float horometro_anterior { get; set;  }
        public float hotometro_actual { get; set;  }
        public DateTime fecha_registro { get; set;  }
        public string descripcion { get; set; } 
        public int id_equipo { get; set; }
        public int id_empleado { get; set; }    
        public float diferencia { get; set; } 
        

        public float CalcularDiferencia()
        {
            return hotometro_actual - horometro_anterior;
        }

    }
}
