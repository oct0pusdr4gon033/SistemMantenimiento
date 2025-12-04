using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Consultas.Equipo
{
    public class datModelo
    {
        private static readonly datModelo _instancia = new datModelo();


        public static datModelo Instancia
        {
            get { return datModelo._instancia; }
        }

    }
}
