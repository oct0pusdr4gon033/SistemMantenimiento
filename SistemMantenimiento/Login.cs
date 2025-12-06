using CapaEntidad;
using CapaEntidad.Usuario;
using CapaLogica;
using CapaLogica.Usuario;
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
    public partial class Login : Form
    {
       
        // Importamos funciones nativas de Windows
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para mover el formulario
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        entUsuarioLogueado log = null;
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // sin borde
            this.MouseDown += new MouseEventHandler(panel_izquiero_MouseDown); // evento global
            this.MouseDown += new MouseEventHandler(panel_derecho_MouseDown); // evento global
            this.MouseDown += new MouseEventHandler(panel_izquiero_MouseDown); // evento global
        
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_izquiero_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // libera el control del mouse
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0); // envía mensaje de "mover ventana"
            }
        }

        private void panel_derecho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // libera el control del mouse
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0); // envía mensaje de "mover ventana"
            }
        }


        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            string user = txb_usuario.Text.Trim();
            string contrasena = txb_password.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                entUsuario usuario = logUsuario.Instancia.Login(user, contrasena);
                log = logUsuarioLogueado.Instancia.CargarUsuarioLogueado(user, contrasena);
                if (usuario != null)
                {
                    
                    ventana_rol(usuario.rol);

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ventana_rol(string rol)
        {
            switch(rol)
            {
                case "Jefe Mantenimiento":
                    JefeMantenimiento jefeMantenimiento = new JefeMantenimiento(log);
                    jefeMantenimiento.Show();


                    break;
                case "Jefe Logistica":
                    JefeLogistica jefeLogistica = new JefeLogistica();
                    jefeLogistica.Show();

                    break;
                case "Planner Mantenimiento":
                    Form PlannerMantenimiento = new Form();
                    PlannerMantenimiento.Show();
                    break; 
                case "Administrador":
                    Administrador administrador = new Administrador();
                    administrador.Show();
                    break;
            }
        }

        private void panel_login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // libera el control del mouse
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0); // envía mensaje de "mover ventana"
            }
        }
    }
}
