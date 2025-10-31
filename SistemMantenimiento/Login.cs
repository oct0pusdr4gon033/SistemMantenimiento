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
            // 1️⃣ Obtener el texto del rol seleccionado (por si no viene)
            rol = cmb_rol.GetItemText(cmb_rol.SelectedItem);

            int id;

            // 2️⃣ Asignar ID según el texto del rol
            switch (rol)
            {
                case "Jefe de Mantenimiento":
                    id = 1;
                    break;

                case "Planner":
                    id = 2;
                    break;

                case "Gerente":
                    id = 3;
                    break;

                case "Jefe de Logística":
                    id = 4;
                    break;

                default:
                    id = 0; // Valor por defecto si no se encuentra el rol
                    break;
            }

            return id;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string user=txb_usuario.Text;
            string password = txb_password.Text;
            int id_rol = GetId(cmb_rol.GetItemText(cmb_rol.SelectedItem));



            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            entUsuario usuario = new entUsuario()
            {
                dni = user,
                password = password,
                id_rol = id_rol
            };
            
            try
            {
                // 4️⃣ Invocar capa lógica
                bool logeado = logUsuario.Instancia.Login(usuario);

                entUsuarioLogueado datosUsuario = logUsuarioLogueado.Instancia.CargarUsuarioLogueado(user, id_rol);
                SesionActual.UsuarioLogueado = datosUsuario;
                // 3️⃣ Guardar en sesión global
                SesionActual.UsuarioLogueado = datosUsuario;

                // 5️⃣ Validar resultado
                if (logeado)
                {
                    MessageBox.Show("Inicio de sesión exitoso", $"Bienvenido {datosUsuario.Nombre} {datosUsuario.Apellido} ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 👉 Aquí puedes abrir tu formulario principal
                    JefeMantenimiento frm = new JefeMantenimiento(datosUsuario);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Verifique su usuario, contraseña o rol.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
