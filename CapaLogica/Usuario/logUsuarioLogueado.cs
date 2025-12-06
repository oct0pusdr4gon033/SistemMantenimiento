using CapaDatos.Consultas.Usuario;
using CapaEntidad;
using CapaEntidad.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica.Usuario
{
    public  class logUsuarioLogueado
    {
        private static readonly logUsuarioLogueado _instancia = new logUsuarioLogueado();
        public static logUsuarioLogueado Instancia => _instancia;

        // 🔹 Este método DEBE devolver un objeto entUsuarioLogueado
        public entUsuarioLogueado CargarUsuarioLogueado(string usuario, string contrasena)
        {
            try
            {
                // Llama al método de la capa de datos y lo devuelve
                return datUsuarioLogueado.Instancia.login(usuario, contrasena);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar datos del usuario logueado", ex);
            }
        }


    }
}
