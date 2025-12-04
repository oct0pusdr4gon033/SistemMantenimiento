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
        #region metodos

        public entArea InsertarArea(entArea area)
        {

            try
            {
                return datArea.Instancia.InsertarArea(area);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en la capa lógica al insertar el área.", ex);
            }
        }

        public List<entArea> ObtenerAreas()
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
        public List<entArea> BuscarArea(string nombreArea)
        {
            try
            {
                var areas = datArea.Instancia.ObtenerAreas();
                return areas.Where(a => a.nombre_area.IndexOf(nombreArea, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en la capa lógica al buscar el área.", ex);
            }
        }
        public bool EditarArea(entArea area_editar)
        {
            try
            {
                return datArea.Instancia.EditarArea(area_editar);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en la capa lógica al editar el área.", ex);
            }
        }

        public entArea ObtenerAreaPorId(int idArea)
        {
            try
            {
                var areas = datArea.Instancia.ObtenerAreas();
                return areas.FirstOrDefault(a => a.id_area == idArea);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en la capa lógica al obtener el área por ID.", ex);
            }
        }

        public bool EliminarArea(int id_area_elimar)
        {
            try
            {
                return datArea.Instancia.EliminarArea(id_area_elimar);
            }
            catch (Exception )
            {
                throw; 
            }
        }
        #endregion


    }
}
