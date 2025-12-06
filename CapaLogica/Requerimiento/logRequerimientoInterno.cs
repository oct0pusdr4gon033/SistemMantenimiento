using CapaDatos.Consultas.Requerimiento;
using CapaEntidad.Requerimiento;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaLogica.Requerimiento
{
    public class logRequerimientoInterno
    {
        private static readonly logRequerimientoInterno _instancia = new logRequerimientoInterno();
        public static logRequerimientoInterno Instancia => _instancia;

        // Generar Código Automático
        public string GenerarCodigo()
        {
            var lista = datRequerimientoInterno.Instancia.Listar();

            if (lista.Count == 0)
                return "REQ-0001";

            // Ordena por ID para obtener el último
            int ultimoId = lista.Max(r => r.id_req);
            string nuevoCodigo = "REQ-" + (ultimoId + 1).ToString("D4");

            return nuevoCodigo;
        }

        // Registrar Requerimiento
        public int RegistrarRequerimiento(entRequerimientoInterno req)
        {
            if (req.id_empleado <= 0)
                throw new Exception("Debe seleccionar un empleado");

            return datRequerimientoInterno.Instancia.RegistrarRequerimiento(req);
        }


        // Buscar Requerimiento por Código + Fecha
        public List<entRequerimientoInterno> BuscarPorCodigoYFecha(string codigo, DateTime fecha)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new Exception("Debe ingresar un código de requerimiento");

            return datRequerimientoInterno
                .Instancia
                .BuscarPorCodigoYFecha(codigo, fecha);
        }

        // Listar todos los requerimientos
        public List<entRequerimientoInterno> Listar()
        {
            return datRequerimientoInterno.Instancia.Listar();
        }
    }
}
