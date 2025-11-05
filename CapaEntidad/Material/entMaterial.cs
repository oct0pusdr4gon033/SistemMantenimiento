using System;

namespace CapaEntidad.Material
{
    public class entMaterial
    {
        // Identificador único del material
        public int IdMaterial { get; set; }

        public string CodigoMaterial { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int IdCategoria { get; set; }

        public int? IdClasificacion { get; set; }

        public int IdUnidad { get; set; }

        public decimal StockActual { get; set; }

        public decimal StockMinimo { get; set; }

        public decimal? StockMaximo { get; set; }

        public decimal? PrecioPromedio { get; set; }

        public decimal? UltimoCosto { get; set; }

        public bool Activo { get; set; }

        public string Criticidad { get; set; }

        public DateTime CreadoEn { get; set; }

        public string NombreCategoria { get; set; }

        public string NombreClasificacion { get; set; }

        public string NombreUnidad { get; set; }
    }
}
