using Guna.UI2.WinForms;
using SistemMantenimiento.Admin;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SistemMantenimiento
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();

            // Mensaje inicial
            MostrarMensajeInicial();

            // Eventos de botones
            btnEmpleados.Click += btnEmpleados_Click;
            btnCargos.Click += btnCargos_Click;
        }

        // Drag window
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MoverVentana(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_rezise_max_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_resize_min.Visible = true;
            btn_rezise_max.Visible = false;
        }

        private void btn_resize_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_resize_min.Visible = false;
            btn_rezise_max.Visible = true;
        }

        // Cargar formularios dentro del panel principal
        private void AbrirFormularioHijo(Form formHijo)
        {
            panelContenido.Controls.Clear();

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void MostrarMensajeInicial()
        {
            panelContenido.Controls.Clear();
            Label label = new Label
            {
                Text = "Seleccione una opción del menú lateral",
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.Gray,
                Location = new Point(80, 80)
            };
            panelContenido.Controls.Add(label);
        }

        // Botones menú lateral
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmEmpleado());
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmCargo());
        }
    }
}
