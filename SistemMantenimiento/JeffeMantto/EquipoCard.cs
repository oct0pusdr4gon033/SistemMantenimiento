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
        // EVENTO que notifica al formulario padre
        public event EventHandler<int> TarjetaClickeada;

        public int IdEquipo { get; private set; }

        public EquipoCard()
        {
            InitializeComponent();
            // ¡IMPORTANTE! Conectar los eventos al crear la tarjeta
            this.Cursor = Cursors.Hand;
            AsociarEventosClickRecursivo(this);
        }

        public void CargarDatos(
            int id_equipo,
            string tipoEquipo,
            string num_serie,
            string marca,
            string modelo,
            DateTime fechaIngreso,
            int anioFabricacion)
        {
            IdEquipo = id_equipo;

            // Asignamos los valores a los Labels
            lbl_id_equipo.Text = id_equipo.ToString();
            lblTipoEquipo.Text = tipoEquipo;
            lblMarca.Text = marca;
            lblModelo.Text = modelo;
            lbl_num_serie.Text = "N° Serie: " + num_serie;
            lblFechaIngreso.Text = "Ingreso: " + fechaIngreso.ToString("dd/MM/yyyy");
            lblAnio.Text = "Fabricación: " + anioFabricacion.ToString();

            // Colores por defecto
            Color colorBorde = Color.FromArgb(240, 240, 240);
            Color colorEtiqueta = Color.FromArgb(224, 224, 224);
           
            // Asignación de colores según tipo de equipo
            if (tipoEquipo.IndexOf("Excavadora", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                colorBorde = Color.FromArgb(255, 249, 219);
                colorEtiqueta = Color.FromArgb(255, 236, 179);
            }
            else if (tipoEquipo.IndexOf("Cargador", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Manipulador", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                colorBorde = Color.FromArgb(219, 255, 226);
                colorEtiqueta = Color.FromArgb(179, 255, 192);
            }
            else if (tipoEquipo.IndexOf("Tractor", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Bulldozer", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                colorBorde = Color.FromArgb(204, 230, 230);
                colorEtiqueta = Color.FromArgb(153, 204, 204);
            }
            else if (tipoEquipo.IndexOf("Camión", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Volquete", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Dumper", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Cisterna", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                colorBorde = Color.FromArgb(219, 247, 255);
                colorEtiqueta = Color.FromArgb(179, 236, 255);
            }
            else if (tipoEquipo.IndexOf("Motoniveladora", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     tipoEquipo.IndexOf("Moto Niveladora", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                colorBorde = Color.FromArgb(255, 230, 224);
                colorEtiqueta = Color.FromArgb(255, 204, 191);
            }
            else if (tipoEquipo.IndexOf("Retroexcavadora", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                colorBorde = Color.FromArgb(227, 232, 240);
                colorEtiqueta = Color.FromArgb(191, 201, 217);
            }

            // Aplicar colores
            pnlBorde.BackColor = colorBorde;
            lblTipoEquipo.BackColor = colorEtiqueta;
        }

        // Conecta recursivamente el evento Click a todos los controles
        private void AsociarEventosClickRecursivo(Control control)
        {
            control.Click += Tarjeta_Click_Unificado;
            control.Cursor = Cursors.Hand;


            foreach (Control hijo in control.Controls)
            {
                AsociarEventosClickRecursivo(hijo);
            }
        }

        // Manejador unificado de clics
        private void Tarjeta_Click_Unificado(object sender, EventArgs e)
        {
            // Buscar la tarjeta padre
            Control parent = (Control)sender;
            while (parent != null && !(parent is EquipoCard))
            {
                parent = parent.Parent;
            }

            if (parent is EquipoCard tarjeta)
            {
                // Disparar el evento para que el formulario padre lo maneje
                TarjetaClickeada?.Invoke(this, tarjeta.IdEquipo);
            }
        }
    }
}
