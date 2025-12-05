using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Equipo;
using CapaDatos.Consultas.Equipo;
namespace CapaLogica.Equipo
{
    public class logTipoEquipo
    {
        private static readonly logTipoEquipo _instancia = new logTipoEquipo();

        public static logTipoEquipo Instancia
        {
            get { return logTipoEquipo._instancia; }
        }

        #region metodos
        public List<entTipoEquipo> ListarTipoEquipo()
        {
            try
            {
                return datTipoEquipo.Instancia.ListarTipoEquipo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public entTipoEquipo InsertarTipoEquipo(entTipoEquipo tipoEquipo)
        {
            try
            {
                return datTipoEquipo.Instancia.InsertarTipoEquipo(tipoEquipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool EditarTipoEquipo(entTipoEquipo tipoEquipo)
        {
            try
            {
                return datTipoEquipo.Instancia.EditarTipoEquipo(tipoEquipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool EliminarTipoEquipo(int id_tipo_equipo)
        {
            try
            {
                return datTipoEquipo.Instancia.EliminarTipoEquipo(id_tipo_equipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<entTipoEquipo> BuscarTipoEquipo(string tipoEquipo_busqueda)
        {
            try
            {
                return datTipoEquipo.Instancia.BuscarTipoEquipo(tipoEquipo_busqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
