using CapaDatos.Consultas.Requerimiento;
using CapaEntidad.Requerimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Requerimiento
{
    internal class logRequerimiento
    {
        public bool Registrar(EntRequerimiento obj, out string Mensaje)
        {
            // ---------------------------------------------------------
            // 1. REGLAS DE NEGOCIO (Validaciones antes de ir a BD)
            // ---------------------------------------------------------

            // Regla 1: Validar que la lista de detalles no esté vacía
            if (obj.ListaDetalles.Count == 0)
            {
                Mensaje = "El requerimiento debe contener al menos un producto.";
                return false;
            }

            // Regla 2: Validar que el código del requerimiento se haya generado (si aplica)
            if (string.IsNullOrEmpty(obj.CodReq))
            {
                Mensaje = "No se ha generado el código del requerimiento.";
                return false;
            }

            // ---------------------------------------------------------
            // 2. LLAMADA A LA CAPA DE DATOS
            // ---------------------------------------------------------

            // Usamos la Instancia Singleton que creaste en D_Requerimiento
            return D_Requerimiento.Instancia.Registrar(obj, out Mensaje);
        }
    }
}
