using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Consultas.Requerimiento;
using CapaEntidad.Requerimiento;

namespace CapaLogica.Requerimiento
{
    public class logRequerimientoInterno
    {
        private static readonly logRequerimientoInterno _instancia = new logRequerimientoInterno();
        public static logRequerimientoInterno Instancia => _instancia;

        public List<entRequerimientoInterno> Listar()
        {
            return datRequerimientoInterno.Instancia.Listar();
        }

        public void Insertar(entRequerimientoInterno r)
        {
            datRequerimientoInterno.Instancia.Insertar(r);
        }

        public void Editar(entRequerimientoInterno r)
        {
            datRequerimientoInterno.Instancia.Editar(r);
        }
    }
}
