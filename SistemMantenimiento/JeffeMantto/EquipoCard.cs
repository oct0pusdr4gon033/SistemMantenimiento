using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemMantenimiento.JeffeMantto
{
    public partial class EquipoCard : UserControl
    {
        public EquipoCard()
        {
            InitializeComponent();
        }
        // --- MÉTODO PÚBLICO PARA LLENAR LOS DATOS ---
        // Tu formulario 'ConsultarEquipo' llamará a esta función
        // por cada tarjeta que quiera crear.
        public void CargarDatos(
            string tipoEquipo,
            string marca,
            string modelo,
            DateTime fechaIngreso,
            int anioFabricacion)
        {
            // Asignamos los valores a los Labels que diseñamos
            
            lblTipoEquipo.Text = tipoEquipo;
            lblMarca.Text = marca;
            lblModelo.Text = modelo;

            // Formateamos los datos restantes
            lblFechaIngreso.Text = "Ingreso: " + fechaIngreso.ToString("dd/MM/yyyy");
            lblAnio.Text = "Fabricación: " + anioFabricacion.ToString();

            // --- Lógica de Color (Mejorada y con nueva paleta) ---

            // Colores por defecto (Gris neutral)
            Color colorBorde = Color.FromArgb(240, 240, 240);
            Color colorEtiqueta = Color.FromArgb(224, 224, 224);

            // Usamos 'else if' para eficiencia.
            // Usamos 'IndexOf' con 'OrdinalIgnoreCase' para ignorar mayúsculas/minúsculas.

            if (tipoEquipo.IndexOf("Excavadora", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                // Paleta "Gold" (Dorado/Arena) - El amarillo que tenías
                colorBorde = Color.FromArgb(255, 249, 219);
                colorEtiqueta = Color.FromArgb(255, 236, 179);
            }
            else if (tipoEquipo.IndexOf("Cargador", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Manipulador", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                // Paleta "Forest" (Verde) - El verde que tenías
                colorBorde = Color.FromArgb(219, 255, 226);
                colorEtiqueta = Color.FromArgb(179, 255, 192);
            }
            else if (tipoEquipo.IndexOf("Tractor", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Bulldozer", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                // Paleta "Teal" (Verde Azulado) - ¡LA QUE PEDISTE!
                // (0, 77, 77) es muy oscuro para un borde, así que usé un "tinte" (versión clara).
                colorBorde = Color.FromArgb(204, 230, 230); // Tinte claro de (0, 77, 77)
                colorEtiqueta = Color.FromArgb(153, 204, 204); // Tinte medio de (0, 77, 77)
            }
            else if (tipoEquipo.IndexOf("Camión", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Volquete", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Dumper", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Cisterna", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                // Paleta "Sky" (Celeste) - El celeste que tenías
                colorBorde = Color.FromArgb(219, 247, 255);
                colorEtiqueta = Color.FromArgb(179, 236, 255);
            }
            else if (tipoEquipo.IndexOf("Motoniveladora", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Moto Niveladora", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                // Paleta "Terracotta" (Naranja/Rojo claro)
                colorBorde = Color.FromArgb(255, 230, 224);
                colorEtiqueta = Color.FromArgb(255, 204, 191);
            }
            else if (tipoEquipo.IndexOf("Retroexcavadora", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                // Paleta "Slate" (Azul/Gris Pizarra)
                colorBorde = Color.FromArgb(227, 232, 240);
                colorEtiqueta = Color.FromArgb(191, 201, 217);
            }
            // (Puedes seguir añadiendo 'else if' para más tipos)

            // Asignación final de colores
            pnlBorde.BackColor = colorBorde;
            lblTipoEquipo.BackColor = colorEtiqueta;
        }
    }
}
