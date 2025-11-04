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

        private void panel_login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // libera el control del mouse
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0); // envía mensaje de "mover ventana"
            }
        }
        public int GetId(string rol)
        {
            // Obtener el texto seleccionado del ComboBox
            rol = cmb_rol.GetItemText(cmb_rol.SelectedItem)?.Trim();

            int id=0;

            switch (rol)
            {
                case "Jefe de Mantenimiento":
                    id = 1;
                    break;

                case "Gerente de Mantenimiento":
                    id = 2;
                    break;

                case "Planner de Mantenimiento":
                    id = 4;
                    break;

                case "Jefe Logistica":
                    id = 3;
                    break;

                default:
                    id = 0; // Valor por defecto si no se encuentra el rol
                    break;
            }

            return id;
        }
        private void AbrirFormularioPorRol(int idRol, entUsuarioLogueado usuario)
        {
            Form frm = null;

            switch (idRol)
            {
                case 1:
                    frm = new JefeMantenimiento(usuario);
                    break;
                case 2:
                    //frm = new Gerente(usuario);
                    break;
                case 3:
                    frm = new JefeLogistica();
                    break;
                case 4:
                    frm = new PlannerMantto(usuario);
                    break;
                default:
                    MessageBox.Show("Rol no reconocido. Contacte con el administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            frm.Show();
            this.Hide();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string user = txb_usuario.Text.Trim();
            string password = txb_password.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            int id_rol = GetId(cmb_rol.GetItemText(cmb_rol.SelectedItem));

            // Crear entidad con el hash
            entUsuario usuario = new entUsuario()
            {
                dni = user,
                password = password,   // Aquí se pasa el hash
                id_rol = id_rol
            };

            try
            {
                // Llamada a la capa lógica
                bool logeado = logUsuario.Instancia.Login(usuario);

                if (logeado)
                {
                    // Puedes cargar los datos del usuario logueado aquí
                    entUsuarioLogueado datosUsuario = logUsuarioLogueado.Instancia.CargarUsuarioLogueado(user, id_rol);
                    SesionActual.UsuarioLogueado = datosUsuario;

                    MessageBox.Show($"Inicio de sesión exitoso.\nBienvenido {datosUsuario.Nombre} {datosUsuario.Apellido}.",
                                    "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir formulario según el rol
                    AbrirFormularioPorRol(id_rol, datosUsuario);
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Verifique su usuario, contraseña o rol.",
                                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
