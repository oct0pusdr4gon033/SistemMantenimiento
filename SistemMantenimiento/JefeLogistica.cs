using Guna.UI2.WinForms;
using SistemMantenimiento.JefeLogi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SistemMantenimiento
{
    public partial class JefeLogistica : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private bool submenuProductoActivo = false;

        public JefeLogistica()
        {
            InitializeComponent();
            ConfigurarEventos();
            CrearOpcionesSubMenuProductos(); // <-- Aquí se carga 1 sola vez
            flp_sub_menu_productos.Visible = false;

        }

        private void JefeLogistica_Load(object sender, EventArgs e)
        {
            flp_sub_menu_productos.Padding = new Padding(20, 5, 0, 5);
            LimpiarPanelCentral();
        }


        private void ConfigurarEventos()
        {
            btn_inicio.Click += (s, e) => LimpiarPanelCentral();

            btn_nota_ingreso.Click += (s, e) => MostrarTitulo("Nota de Ingreso");
            btn_nota_salida.Click += (s, e) => MostrarTitulo("Nota de Salida");
            btn_proveedores.Click += (s, e) => MostrarTitulo("Proveedores");
            btn_requerimientos.Click += (s, e) => MostrarTitulo("Requerimientos");

            // ❌ ELIMINAR ESTA
            // btn_producto.Click += btn_producto_Click;
        }


        private void btn_producto_Click(object sender, EventArgs e)
        {
            submenuProductoActivo = !submenuProductoActivo;

            btn_producto.Text = submenuProductoActivo ? "Producto ▲" : "Producto ▼";
            flp_sub_menu_productos.Visible = submenuProductoActivo;
        }




        private void CrearOpcionesSubMenuProductos()
        {
            flp_sub_menu_productos.Controls.Clear();

            void Add(string texto, Action accion)
            {
                var btn = new Guna2Button
                {
                    Text = texto,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold),
                    FillColor = Color.Transparent,
                    Size = new Size(202, 35),
                    BorderRadius = 6,
                    Cursor = Cursors.Hand
                };
                btn.Click += (s, e) => accion();
                flp_sub_menu_productos.Controls.Add(btn);
            }

            Add("📦 Gestión Productos", () => AbrirFormularioHijo(new frmProducto()));
            Add("🏷 Marca", () => AbrirFormularioHijo(new frmMarcas()));
            Add("📁 Categoría", () => AbrirFormularioHijo(new frmCategorias()));
            Add("📐 Unidad de Medida", () => AbrirFormularioHijo(new frmUnidades()));
        }


        // Mostrar títulos simples
        private void MostrarTitulo(string texto)
        {
            panel_form_hijo.Controls.Clear();
            var label = new Label
            {
                Text = texto,
                AutoSize = true,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 77, 77),
                Location = new Point(50, 50)
            };
            panel_form_hijo.Controls.Add(label);
        }

        private void LimpiarPanelCentral()
        {
            panel_form_hijo.Controls.Clear();
            var label = new Label
            {
                Text = "Seleccione una opción del menú lateral",
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.Gray,
                Location = new Point(100, 100)
            };
            panel_form_hijo.Controls.Add(label);
        }

        // Movimiento Form
        private void panel_side_bar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void panel_superio_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
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
            this.WindowState = FormWindowState.Normal;
            btn_resize_min.Visible = false;
            btn_rezise_max.Visible = true;
        }

        private void btn_rezise_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_rezise_max.Visible = false;
            btn_resize_min.Visible = true;
        }

        // Abrir formularios dentro del panel
        private void AbrirFormularioHijo(Form frm)
        {
            panel_form_hijo.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panel_form_hijo.Controls.Add(frm);
            frm.Show();
        }

    }
}
