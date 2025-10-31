using CapaDatos.Consultas.Usuario;
using CapaEntidad;
using CapaEntidad.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUsuario
    {
        private static readonly logUsuario _instancia = new logUsuario();
        public static logUsuario Instancia
        {
            get { return logUsuario._instancia; }
        }

        public bool Login(entUsuario usuario)
        {
            usuario.password = segEncriptacion.EncriptarSHA256(usuario.password);
            return datUsuario.Instancia.Login(usuario);
        }
        // 🔹 Este método DEBE devolver un objeto entUsuarioLogueado
        public entUsuarioLogueado CargarUsuarioLogueado(string dni, int idRol)
        {
            try
            {
                // Llama al método de la capa de datos y lo devuelve
                return datUsuarioLogueado.Instancia.ObtenerDatosUsuario(dni, idRol);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar datos del usuario logueado", ex);
            }
        }


    }
}
