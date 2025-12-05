using CapaDatos.Consultas.Equipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Equipo;


namespace CapaLogica.Equipo
{
    public class logModelo
    {   
        private static readonly logModelo _instancia = new logModelo();

        public static logModelo Instancia
        {
            get { return logModelo._instancia; }
        }

        public entModelo InsertarModelo(entModelo modelo)
        {
            try
            {
                return datModelo.Instancia.InsertarModelo(modelo);

            }catch 
            {
                throw; 
            }
        }
        public bool EditarMarca(entModelo modelo)
        {

            try
            {
                return datModelo.Instancia.EditarModelo(modelo);
            }catch
            {
                throw; 
            }
        }
        public bool EliminarModelo(int id_modelo_eliminar)
        {
            try
            {
                return datModelo.Instancia.EliminarModelo(id_modelo_eliminar);
            }catch
            {
                throw; 
            }
        }
        public List<entModelo> ListarModelos()
        {
            try
            {
                return datModelo.Instancia.ListarModelos();
            }catch
            {
                throw; 
            }
        }
        public List<entModelo> BuscarModelo(string modelo_busqueda)
        {
            try
            {
                return datModelo.Instancia.BuscarModelo(modelo_busqueda);
            }catch
            {
                throw; 
            }
        }
    }
}
