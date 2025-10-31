using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Usuario
{
    public class entUsuarioLogueado
    {
        public int IdUsuario { get; set; }      // Opcional, pero útil para registrar acciones
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rol { get; set; }
    }
}
