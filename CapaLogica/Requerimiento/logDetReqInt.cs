using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Requerimiento;
using CapaDatos.Consultas.Requerimiento;

namespace CapaLogica.Requerimiento
{
    public class logDetReqInt
    {
        private static readonly logDetReqInt _instancia = new logDetReqInt();
        public static logDetReqInt Instancia => _instancia;

        // Insertar Detalle con validación
        public string InsertarDetalle(entDetReqInt det)
        {
            if (det.id_requerimiento <= 0)
                return "Requerimiento inválido.";

            if (det.id_material <= 0)
                return "Debe seleccionar un producto válido.";

            if (det.cantidad <= 0)
                return "La cantidad debe ser mayor a cero.";

            bool ok = datDetReqInt.Instancia.InsertarDetalle(det);

            return ok ? "Producto agregado al requerimiento."
                      : "Error al agregar el producto.";
        }

        // Obtener detalles por id de requerimiento
        public List<entDetReqInt> ListarDetallesPorRequerimiento(int idReq)
        {
            if (idReq <= 0)
                return new List<entDetReqInt>();

            return datDetReqInt.Instancia.ListarDetallesPorRequerimiento(idReq);
        }
    }
}
