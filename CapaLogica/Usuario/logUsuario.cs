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

        public entUsuario Login(string username, string password)
        {
            return datUsuario.Instancia.Login(username, password);
        }
        // 🔹 Este método DEBE devolver un objeto entUsuarioLogueado
       


    }
}
