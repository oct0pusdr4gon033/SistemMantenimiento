using CapaEntidad.Usuario;
using Guna.UI2.WinForms;
using SistemMantenimiento.FuncionesAuxiliares;
using SistemMantenimiento.JeffeMantto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemMantenimiento
{
    public partial class JefeMantenimiento : Form
    {

        // Importamos funciones nativas de Windows
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para mover el formulario
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private string inicialesUsuario = "";
        FuncionesAuxiliares.Auxiliares aux = new FuncionesAuxiliares.Auxiliares();
        private SubMenuManager subMenuEquipos;
        private Form formularioActivo = null;


        public JefeMantenimiento(entUsuarioLogueado usuario)
        {
            InitializeComponent();
            panel_form_hijo.Visible= false;
            btn_resize_min.Visible=false;
            DateTime dia = DateTime.Now;
            string formatoPersonalizado = dia.ToString("dddd, dd 'de' MMMM yyyy",
                                                       new System.Globalization.CultureInfo("es-ES"));
            // Capitalizamos la primera letra del día y del mes
            formatoPersonalizado = System.Globalization.CultureInfo.CurrentCulture.TextInfo
                .ToTitleCase(formatoPersonalizado);

            lbl_fecha_bienvenida.Text = formatoPersonalizado;
            lbl_rol_bienvenida.Text = usuario.Rol;
            lbl_usuario_bienvenida.Text = usuario.Nombre + " " + usuario.Apellido;
            inicialesUsuario = aux.ObtenerIniciales(usuario.Nombre + " " + usuario.Apellido);
            load_sub_menu_equipos();
        }
       

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_resize_min_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btn_resize_min.Visible = false; 
            btn_rezise_max.Visible = true;
        }

        private void btn_rezise_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_rezise_max.Visible = false;
            btn_resize_min.Visible = true;
        }

        private void panel_superio_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // libera el control del mouse
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0); // envía mensaje de "mover ventana"
            }
        }

        private void panel_side_bar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // libera el control del mouse
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0); // envía mensaje de "mover ventana"
            }
        }

        private void flp_panel_principal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // libera el control del mouse
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0); // envía mensaje de "mover ventana"
            }
        }

        private void panel_perfil_Paint(object sender, PaintEventArgs e)
        {
            AvatarRenderer.DibujarAvatar(panel_perfil, e, inicialesUsuario);
        }
        private void CargarTarjetasDashboard(FlowLayoutPanel panelContenedor)
        {
            panelContenedor.Controls.Clear();

            var card1 = new TarjetaKPI_Emoji("248", "Total Equipos", Color.FromArgb(0, 128, 128), "⚙️");
            var card2 = new TarjetaKPI_Emoji("42", "Trabajos Completados", Color.FromArgb(40, 167, 69), "✅");
            var card3 = new TarjetaKPI_Emoji("18", "En Progreso", Color.FromArgb(108, 117, 125), "⌛");
            var card4 = new TarjetaKPI_Emoji("5", "Urgentes", Color.FromArgb(255, 128, 0), "⚠️");

            panelContenedor.Controls.Add(card1.PanelTarjeta);
            panelContenedor.Controls.Add(card2.PanelTarjeta);
            panelContenedor.Controls.Add(card3.PanelTarjeta);
            panelContenedor.Controls.Add(card4.PanelTarjeta);
        }

        private void JefeMantenimiento_Load(object sender, EventArgs e)
        {
            CargarTarjetasDashboard(flp_tarjetaas_kpi);
        }
        private void load_sub_menu_equipos()
        {
            // --- ESTA ES LA PARTE CLAVE ---
            // 1. Crea un Diccionario que une el texto (string) con una acción (Action)
            var opcionesConAcciones = new Dictionary<string, Action>
            {
                // Key: "El texto del botón"
                // Value: () => La_Accion_A_Ejecutar()
        
                { "➕ Crear Equipo",             () => AbrirFormularioEnPanel(new AgregarEquipos()) },
                { "✏️ Editar/Actualizar Equipo",  () => AbrirFormularioEnPanel(new EditarEquipo()) },
                { "🔍 Consultar Equipos",         () => AbrirFormularioEnPanel(new ConsultarEquipo()) },
                { "⏱️ Actualizar Horómetro",    () => AbrirFormularioEnPanel(new Horometros()) },
                { "📜 Historial de Mantenimiento", () => AbrirFormularioEnPanel(new VerHistorialMantto()) }
            };

            // 2. Llama a tu SubMenuManager (asumiendo que lo modificaste para aceptar el Diccionario)
            subMenuEquipos = new SubMenuManager(
                this,                     // Form principal
                btn_equipos,              // Tu botón principal Guna2
                panel_sub_menu_equipos,   // Panel contenedor del submenú
                flp_sub_menu_equipos,     // FlowLayoutPanel interno
                opcionesConAcciones       // ¡Le pasamos el Diccionario!
            );
        }
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // 1. Si ya hay un formulario abierto, lo cerramos
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }


            // 2. Guardamos la referencia del nuevo formulario
            formularioActivo = formularioHijo;
            // 3. Configuramos el formulario para que actúe como un control
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill; // <-- ¡Tu línea mágica!

            // 4. Limpiamos el panel y añadimos el nuevo formulario (UNA SOLA VEZ)
            panel_form_hijo.Visible = true;
            panel_form_hijo.BringToFront();
            panel_form_hijo.Controls.Clear();
            panel_form_hijo.Controls.Add(formularioHijo);
            panel_form_hijo.Tag = formularioHijo;

            // 5. Lo mostramos
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }



    }
    
}
