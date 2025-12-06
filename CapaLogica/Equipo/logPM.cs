using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Equipo;
namespace CapaLogica.Equipo
{
    public class logPM
    {
        private static readonly logPM _instancia = new logPM();
        public static logPM Instancia
        {
            get { return logPM._instancia; }
        }

        public entPM InsertarPM(entPM pm)
        {
            try
            {
                return CapaDatos.Consultas.Equipo.datPM.Instancia.InsertarPM(pm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
