using CapaDatos.Consultas.Equipo;
using CapaEntidad.Equipo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaLogica.Equipo
{
    public class logEquipo
    {
        private static readonly logEquipo _instancia = new logEquipo();
        private datEquipo objDatos = new datEquipo();
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
        public List<entEquipo> ListarTop5Equipos()
        {
            // Simplemente llama al método de la capa de datos
            // y devuelve lo que esta le da.
            return objDatos.extraer_top_five();
        }
        public List<entEquipo> BuscarEquipos(
             // ¡CORREGIDO! Aceptamos los 5 parámetros del formulario
             string tipo,
             string marca,
             int? anio,
             string modelo,
             string fecha)
        {
            try
            {
                // ¡CORREGIDO! Llamamos a la Capa de Datos
                // con los mismos 5 parámetros
                return datEquipo.Instancia.BuscarEquipos(
                    tipo,
                    marca,
                    anio,
                    modelo,
                    fecha);
            }
            catch (Exception ex)
            {
                // Tu manejo de errores es perfecto
                throw new Exception("Error al buscar equipos desde la capa lógica: " + ex.Message, ex);
            }
        }

    }
}
