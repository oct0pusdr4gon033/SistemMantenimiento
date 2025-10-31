using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemMantenimiento.FuncionesAuxiliares
{
    public class SubMenuManager
    {
        private readonly Form _formPadre;
        private readonly Guna2Button _botonPrincipal;
        private readonly Panel _panelSubMenu;
        private readonly FlowLayoutPanel _flowSubMenu;

        private Dictionary<string, Action> _opcionesConAcciones;
        public SubMenuManager(Form formPadre, Guna2Button botonPrincipal, Panel panelSubMenu, FlowLayoutPanel flowSubMenu, Dictionary<string,Action> opciones)
        {
            _formPadre = formPadre;
            _botonPrincipal = botonPrincipal;
            _panelSubMenu = panelSubMenu;
            _flowSubMenu = flowSubMenu;
            _opcionesConAcciones = opciones;

            InicializarSubMenu();
        }

        private void InicializarSubMenu()
        {
            // --- 1. CONFIG ESTÉTICA BOTÓN PRINCIPAL ---
            Color colorSombreado = Color.FromArgb(50, 80, 90, 100);
            _botonPrincipal.CheckedState.FillColor = colorSombreado;
            _botonPrincipal.CheckedState.ForeColor = _botonPrincipal.ForeColor;
            _botonPrincipal.CheckedState.Font = _botonPrincipal.Font;

            // --- 2. CONFIGURACIÓN DE PANEL ---
            _panelSubMenu.Visible = false;
            _botonPrincipal.Checked = false;

            // --- 3. FLOWLAYOUT ---
            _flowSubMenu.FlowDirection = FlowDirection.TopDown;
            _flowSubMenu.Dock = DockStyle.Fill;
            _flowSubMenu.Controls.Clear();

            int panelWidth = _panelSubMenu.Width;
            int buttonWidth = 180;
            int horizontalPadding = (panelWidth - buttonWidth) / 2;
            _flowSubMenu.Padding = new Padding(horizontalPadding, 10, horizontalPadding, 5);

            // --- 4. CREAR BOTONES ---
            // AHORA ES CORRECTO: Iteramos sobre el "par" (Key/Value)
            foreach (KeyValuePair<string, Action> par in _opcionesConAcciones)
            {
                // 1. "Desempacamos" el par
                string textoBoton = par.Key;   // El texto para el botón
                Action accionBoton = par.Value; // La ACCIÓN (ej: abrir el formulario)

                Guna2Button btnOpcion = new Guna2Button()
                {
                    Text = textoBoton, // <-- Usamos el 'string' que desempacamos
                    Width = buttonWidth,
                    Height = 35,
                    BorderRadius = 8,
                    FillColor = Color.Transparent,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Animated = true,
                    Margin = new Padding(0, 0, 0, 5)
                };

                // 2. Asignamos la ACCIÓN correcta al evento Click
                btnOpcion.Click += (s, e) =>
                {
                    // ¡ESTA ES LA LÍNEA MÁS IMPORTANTE!
                    // Ejecuta la acción que guardamos (ej: AbrirFormularioEnPanel)
                    accionBoton();

                    // (Opcional: ya no necesitas el MessageBox, pero si lo quieres, usa 'textoBoton')
                    // MessageBox.Show($"Has seleccionado: {textoBoton}", "Acción del Submenú"); 

                    // Cierra el menú
                    _panelSubMenu.Visible = false;
                    _botonPrincipal.Checked = false;
                };

                _flowSubMenu.Controls.Add(btnOpcion);
            }
            // --- 5. EVENTO CLIC PRINCIPAL ---
            _botonPrincipal.Click += (s, e) =>
            {
                _botonPrincipal.Checked = !_botonPrincipal.Checked;
                _panelSubMenu.Visible = _botonPrincipal.Checked;

                if (_botonPrincipal.Checked)
                    _panelSubMenu.BringToFront();
            };

            // --- 6. CLIC FUERA DEL PANEL ---
            _formPadre.Click += (s, e) =>
            {
                if (_botonPrincipal.Checked)
                {
                    Point mousePos = _formPadre.PointToClient(Cursor.Position);

                    if (!_panelSubMenu.Bounds.Contains(mousePos) &&
                        !_botonPrincipal.Bounds.Contains(mousePos))
                    {
                        _panelSubMenu.Visible = false;
                        _botonPrincipal.Checked = false;
                    }
                }
            };
        }
    }
}
