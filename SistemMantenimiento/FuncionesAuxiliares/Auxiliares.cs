using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemMantenimiento.FuncionesAuxiliares
{
    public class Auxiliares
    {
        public string ObtenerIniciales(string nombreCompleto)
        {
            if (string.IsNullOrWhiteSpace(nombreCompleto))
                return string.Empty;

            // Split clásico compatible con todas las versiones de .NET
            string[] partes = nombreCompleto.Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string iniciales = "";
            for (int i = 0; i < partes.Length && i < 2; i++)
            {
                iniciales += partes[i][0];
            }

            return iniciales.ToUpper();
        }
    }
}
