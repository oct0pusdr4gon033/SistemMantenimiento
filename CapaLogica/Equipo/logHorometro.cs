using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Consultas.Equipo;

namespace CapaLogica.Equipo
{
    public class logHorometro
    {
        private static readonly logHorometro _instancia = new logHorometro();
        public static logHorometro Instancia
        {
            get { return logHorometro._instancia; }
        }

        public bool InsertarHorometro(CapaEntidad.Equipo.entHorometro horometro)
        {
            try
            {
                return datHorometro.Instancia.InsertarHorometro(horometro);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CapaLogica al insertar Horometro: " + ex.Message);
            }
        }

    }
}
