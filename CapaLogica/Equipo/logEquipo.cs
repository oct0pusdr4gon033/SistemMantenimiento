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
        public bool ActualizarEquipo(entEquipo equipo, string usuarioEdito, string motivo)
        {
            // ✅ Validaciones previas a nivel lógico (antes de tocar la BD)
            if (equipo == null)
                throw new ArgumentNullException("El objeto equipo no puede ser null.");

            if (equipo.id_equipo <= 0)
                throw new ArgumentException("El ID del equipo no es válido.");

            if (string.IsNullOrWhiteSpace(usuarioEdito))
                throw new ArgumentException("El usuario que edita no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(motivo))
                motivo = "Modificación de datos del equipo"; // default

            // ✅ Llamar a la capa de datos (SQL Server)
            try
            {
                return datEquipo.Instancia.ActualizarEquipo(equipo, usuarioEdito, motivo);
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción aquí o lanzarla hacia arriba
                throw new Exception($"Error en lógica al actualizar el equipo: {ex.Message}", ex);
            }
        }

        public bool existe_bitacora(int id_equipo)
        {
            return datEquipo.Instancia.existe_bitacora(id_equipo);
        }

        public bool dar_baja_equipo(int id_equipo)
        {
            return datEquipo.Instancia.dar_baja_equipo(id_equipo);
        }





    }
}
