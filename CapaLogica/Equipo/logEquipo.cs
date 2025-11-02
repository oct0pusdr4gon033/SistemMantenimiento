using CapaDatos.Consultas.Equipo;
using CapaEntidad.Equipo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
               
                throw new ApplicationException("Error en la capa lógica al registrar el equipo.", ex);
            }
        }
        public List<entEquipo> ListarTop5Equipos()
        {
        
            return objDatos.extraer_top_five();
        }
        public List<entEquipo> BuscarEquipos(
             
             string tipo,
             string marca,
             int? anio,
             string modelo,
             string fecha,
             string num_serie)
        {
            try
            {
                
                return datEquipo.Instancia.BuscarEquipos(
                    tipo,
                    marca,
                    anio,
                    modelo,
                    fecha,
                    num_serie);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al buscar equipos desde la capa lógica: " + ex.Message, ex);
            }
        }

        public int ContarEquipos()
        {
            try
             {
                int conteo = datEquipo.Instancia.contar_equipos();

                if (conteo == 0)
                {
                    throw new Exception("No hay equipos registrados en el sistema.");
                }
                return conteo;
            }
            catch (Exception ex)
            {
      
                throw new Exception("Error en la capa lógica al contar equipos.", ex);
            }
  
        }

        public entEquipo ObtenerEquipoPorId(int id_equipo)
        {
            try
            {
                return datEquipo.Instancia.obtener_equipos_id(id_equipo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el equipo por ID desde la capa lógica: " + ex.Message, ex);
            }
        }





    }
}
