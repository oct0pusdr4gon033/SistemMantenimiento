using CapaDatos.Consultas.Equipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Equipo;


namespace CapaLogica.Equipo
{
    internal class logModelo
    {   
        private static readonly logModelo _instancia = new logModelo();

        public static logModelo Instancia
        {
            get { return logModelo._instancia; }
        }
    }
}
