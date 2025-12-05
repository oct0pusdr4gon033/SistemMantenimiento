using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Consultas.Equipo;
using CapaEntidad.Equipo;
namespace CapaLogica.Equipo
{
    public class logMarca
    {
        private static readonly logMarca _instancia = new logMarca();

        public static logMarca Instancia
        {
            get { return logMarca._instancia; }
        }

        public entMarca InsertarMarca(entMarca marca)
        {
            try
            {
                return datMarca.Instancia.InsertarMarca(marca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<entMarca> BuscarMarca(string marca_busqueda)
        {
            try
            {
                return datMarca.Instancia.BuscarMarca(marca_busqueda);
            }
            catch
            {
                throw; 
            }
        }
        public List<entMarca> ListarMarcas()
        {
            try
            {
                return datMarca.Instancia.ListarMarcas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool EditarMarca(entMarca marca)
        {
            try
            {
                return datMarca.Instancia.EditarMarca(marca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarMarca(int id_marca)
        {
            try
            {
                return datMarca.Instancia.EliminarMarca(id_marca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
