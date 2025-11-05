using CapaEntidad.Usuario;
using CapaLogica.Equipo;
using SistemMantenimiento.FuncionesAuxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemMantenimiento.JeffeMantto
{
    public partial class frm_Inicio : Form
    {
        private string inicialesUsuario = "";

        Auxiliares aux = new Auxiliares();
        public frm_Inicio(entUsuarioLogueado usuario)
        {
            InitializeComponent();
            DateTime dia = DateTime.Now;
            string formatoPersonalizado = dia.ToString("dddd, dd 'de' MMMM yyyy",
                                                       new System.Globalization.CultureInfo("es-ES"));
            // Capitalizamos la primera letra del día y del mes
            formatoPersonalizado = System.Globalization.CultureInfo.CurrentCulture.TextInfo
                .ToTitleCase(formatoPersonalizado);

            lbl_fecha_bienvenida.Text = formatoPersonalizado;
            lbl_rol_bienvenida.Text = usuario.Rol;
            inicialesUsuario = aux.ObtenerIniciales(usuario.Nombre + " " + usuario.Apellido);
            lbl_usuario_bienvenida.Text = usuario.Nombre + " " + usuario.Apellido;
        
            
        }

        private void frm_Inicio_Load(object sender, EventArgs e)
        {
            CargarTarjetasDashboard(flp_panel_kpi);
        }
        private void CargarTarjetasDashboard(FlowLayoutPanel panelContenedor)
        {
            panelContenedor.Controls.Clear();
            //var card1 = new TarjetaKPI_Emoji(conteo_equipos(logEquipo.Instancia.ContarEquipos()), "Total Equipos", Color.FromArgb(0, 128, 128), "⚙️");
            var card2 = new TarjetaKPI_Emoji("42", "Trabajos Completados", Color.FromArgb(40, 167, 69), "✅");
            var card3 = new TarjetaKPI_Emoji("18", "En Progreso", Color.FromArgb(108, 117, 125), "⌛");
            var card4 = new TarjetaKPI_Emoji("5", "Urgentes", Color.FromArgb(255, 128, 0), "⚠️");
            var card5 = new TarjetaKPI_Emoji("3", "Urgentes de la semana", Color.FromArgb(255, 128, 0), "⚠️");

           // panelContenedor.Controls.Add(card1.PanelTarjeta);
            panelContenedor.Controls.Add(card2.PanelTarjeta);
            panelContenedor.Controls.Add(card3.PanelTarjeta);
            panelContenedor.Controls.Add(card4.PanelTarjeta);
            panelContenedor.Controls.Add(card5.PanelTarjeta);
        }
        public string conteo_equipos(int numero)
        {
            return numero.ToString();
           
        }

        private void panel_perfil_Paint(object sender, PaintEventArgs e)
        {
            AvatarRenderer.DibujarAvatar(panel_perfil, e, inicialesUsuario);
        }
    }
}
