using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices; // <--- IMPORTANTE: Añadido para los DllImport
using System.Windows.Forms;

namespace SistemMantenimiento
{
    public partial class JefeLogistica : Form
    {
        // --- DLLIMPORTS PARA MOVER EL FORMULARIO ---
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para movimiento de ventana
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public JefeLogistica()
        {
            InitializeComponent();
            ConfigurarEventos();
        }

        private void JefeLogistica_Load(object sender, EventArgs e)
        {
            LimpiarPanelCentral();
        }

        // CONFIGURACIÓN DE BOTONES
        private void ConfigurarEventos()
        {
            btn_inicio.Click += (s, e) => LimpiarPanelCentral();

            btn_nota_ingreso.Click += (s, e) => MostrarSubOpciones("Nota de Ingreso", new List<string>
            {
                "➕ Agregar Nota de Ingreso",
                "❌ Anular Nota de Ingreso"
            });

            btn_nota_salida.Click += (s, e) => MostrarSubOpciones("Nota de Salida", new List<string>
            {
                "➕ Agregar Nota de Salida",
                "❌ Anular Nota de Salida"
            });

            btn_materiales.Click += (s, e) => MostrarSubOpciones("Materiales", new List<string>
            {
                "➕ Agregar Material",
                "✏️ Modificar Material",
                "🗑️ Eliminar Material"
            });

            btn_proveedores.Click += (s, e) => MostrarSubOpciones("Proveedores", new List<string>
            {
                "➕ Agregar Proveedor",
                "✏️ Modificar Proveedor",
                "🗑️ Eliminar Proveedor"
            });

            btn_requerimientos.Click += (s, e) => MostrarSubOpciones("Requerimientos", new List<string>
            {
                "➕ Agregar Requerimiento",
                "✏️ Modificar Requerimiento"
            });
        }

        // CONSTRUCCIÓN DINÁMICA DE SUBMENÚS
        private void MostrarSubOpciones(string titulo, List<string> subOpciones)
        {
            panel_form_hijo.Controls.Clear();

            // Obtener el ancho del panel para centrar elementos
            int panelWidth = panel_form_hijo.Width;

            // Título
            var lblTitulo = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 77, 77),
                AutoSize = true
            };
            lblTitulo.Location = new Point((panelWidth - lblTitulo.Width) / 2, 20);
            panel_form_hijo.Controls.Add(lblTitulo);

            int posY = 80;

            foreach (var texto in subOpciones)
            {
                var subBtn = new Guna2Button
                {
                    Text = texto,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.White,
                    FillColor = Color.FromArgb(0, 100, 100),
                    Size = new Size(280, 40),
                    BorderRadius = 6
                };
                subBtn.Location = new Point((panelWidth - subBtn.Width) / 2, posY);

                // subBtn.Click += (s, e) => AbrirFormularioCorrespondiente(texto);
                panel_form_hijo.Controls.Add(subBtn);
                posY += 55;
            }

            // PANEL DE ÚLTIMAS INSERCIONES
            var panelUltimos = new Guna2Panel
            {
                BorderColor = Color.Silver,
                BorderThickness = 1,
                BorderRadius = 10,
                Size = new Size(550, 180),
                FillColor = Color.WhiteSmoke
            };
            panelUltimos.Location = new Point((panelWidth - panelUltimos.Width) / 2, posY + 20);

            var lblUltimos = new Label
            {
                Text = "🕒 Últimas 5 inserciones registradas",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(15, 10),
                AutoSize = true
            };
            panelUltimos.Controls.Add(lblUltimos);

            // Crear etiquetas ficticias de registros
            int itemY = 40;
            for (int i = 1; i <= 5; i++)
            {
                var lblItem = new Label
                {
                    Text = $"{i}. Ejemplo de {titulo} agregada el {DateTime.Now.AddDays(-i):dd/MM/yyyy}",
                    Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                    ForeColor = Color.DimGray,
                    AutoSize = true,
                    Location = new Point(20, itemY)
                };
                panelUltimos.Controls.Add(lblItem);
                itemY += 25;
            }

            panel_form_hijo.Controls.Add(panelUltimos);

            // Botón Volver
            var btnVolver = new Guna2Button
            {
                Text = "⬅️ Volver",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                FillColor = Color.Gray,
                BorderRadius = 6,
                Size = new Size(100, 35)
            };
            btnVolver.Location = new Point((panelWidth - btnVolver.Width) / 2, posY + 220);
            btnVolver.Click += (s, e) => LimpiarPanelCentral();
            panel_form_hijo.Controls.Add(btnVolver);
        }


        // ESTADO INICIAL DEL PANEL CENTRAL
        private void LimpiarPanelCentral()
        {
            panel_form_hijo.Controls.Clear();

            var lblBienvenida = new Label
            {
                Text = "Seleccione una opción del menú lateral",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(100, 100)
            };

            panel_form_hijo.Controls.Add(lblBienvenida);
        }

        // MOVIMIENTO DE FORMULARIO
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

        // BOTONES DE CONTROL DE VENTANA
        private void btn_rezise_max_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void btn_resize_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}