using CapaEntidad.Equipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Consultas.Equipo;


namespace CapaLogica.Equipo
{
    public class logEquipo
    {
        private static readonly logEquipo _instancia = new logEquipo();
        public static logEquipo Instancia
        {
            get { return logEquipo._instancia; }
        }

        public entEquipo insertar_equipo(entEquipo equipo)
        {
            try
            {
                return datEquipo.Instancia.InsertarEquipo(equipo);
            }
            catch (Exception ex)
            {
                // Relanzamos la excepción con contexto adicional
                throw new ApplicationException("Error en la capa lógica al registrar el equipo.", ex);
            }
        }
    }
}
