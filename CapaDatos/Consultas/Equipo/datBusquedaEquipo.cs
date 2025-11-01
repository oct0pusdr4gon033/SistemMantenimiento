using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Consultas.Equipo
{
    public  class datBusquedaEquipo
    {
        private static readonly datBusquedaEquipo _instancia = new datBusquedaEquipo();


        public static datBusquedaEquipo Instancia
        {
            get { return datBusquedaEquipo._instancia; }
        }

        #region metodos 

        /////////////////////////metodos de equipo
        /////Buscar por marca 
        ///Buscar Tipo de Equipo
        /// Buscar Año de Fabricacion
        ///Buscar Número Serie
      
        #endregion

    }
}
