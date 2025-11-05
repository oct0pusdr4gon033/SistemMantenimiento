using CapaDatos.Consultas.Equipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Equipo;

namespace CapaLogica.Equipo
{
    public class logArea
    {
        private static readonly logArea _instancia = new logArea();
       
        public static logArea Instancia
        {
            get { return logArea._instancia; }
        }

        public List<Area> ObtenerAreas()
        {
            try
            {
                return datArea.Instancia.ObtenerAreas();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en la capa lógica al obtener las áreas.", ex);
            }
        }

       public Area ObtenerAreaPorId(int idArea)
        {
            try
            {
                var areas = datArea.Instancia.ObtenerAreas();
                return areas.FirstOrDefault(a => a.IdArea == idArea);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en la capa lógica al obtener el área por ID.", ex);
            }
        }


    }
}
