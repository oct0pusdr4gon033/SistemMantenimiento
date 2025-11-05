using CapaEntidad.Equipo;
using CapaEntidad.Usuario;
using CapaLogica.Equipo;
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
        entUsuarioLogueado usuarioLogueado = null; 
        entEquipo equipo_seleccionado;



        public JefeMantenimiento(entUsuarioLogueado usuario)
        {
            InitializeComponent();
            panel_form_hijo.Visible= false;
            btn_resize_min.Visible=false;
            usuarioLogueado = usuario; 
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
        private void JefeMantenimiento_Load(object sender, EventArgs e)
        {
           
            if (this.usuarioLogueado != null)
            {
                AbrirFormularioEnPanel(new frm_Inicio(this.usuarioLogueado));
            }
            else
            {
            
                MessageBox.Show("Error crítico: No se pudo cargar la información del usuario.", "Error de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); // O this.Close() para volver al Login
            }

        }
        private void load_sub_menu_equipos()
        {
            var opcionesConAcciones = new Dictionary<string, Action>
            {
                { "➕ Crear Equipo", () => AbrirFormularioEnPanel(new AgregarEquipos()) },

                { "✏️ Editar Equipo", () =>
                    {
                        if (equipo_seleccionado != null)
                            AbrirFormularioEnPanel(new EditarEquipo(equipo_seleccionado, usuarioLogueado));
                        else
                            AbrirFormularioEnPanel(new EditarEquipo()); // ✅ abrir sin entidad
                    }
                },

                { "🔍 Consultar Equipos", () =>
                    {
                        if (usuarioLogueado != null)
                            AbrirFormularioEnPanel(new ConsultarEquipo(usuarioLogueado));
                        else
                            AbrirFormularioEnPanel(new ConsultarEquipo()); // ✅ sin usuario
                    }
                },

                { "⏱️ Actualizar Horómetro", () =>
                    {
                        if (equipo_seleccionado != null)
                            AbrirFormularioEnPanel(new Horometros(equipo_seleccionado));
                        else
                            AbrirFormularioEnPanel(new Horometros()); // ✅ constructor alternativo
                    }
                },

                { "📜 Historial de Mantenimiento", () =>
                    {
                        if (equipo_seleccionado != null)
                            AbrirFormularioEnPanel(new GenerarPM(equipo_seleccionado));
                        else
                            AbrirFormularioEnPanel(new GenerarPM()); // ✅ sin entidad
                    }
                }
            };

            subMenuEquipos = new SubMenuManager(
                this,
                btn_equipos,
                panel_sub_menu_equipos,
                flp_sub_menu_equipos,
                opcionesConAcciones
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

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frm_Inicio(usuarioLogueado));
  
        }

    }
    
}