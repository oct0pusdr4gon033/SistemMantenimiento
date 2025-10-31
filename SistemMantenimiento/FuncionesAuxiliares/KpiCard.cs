using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace SistemMantenimiento.FuncionesAuxiliares
{
    /// <summary>
    /// Una tarjeta KPI personalizada que se auto-construye y
    /// hereda de Guna2ShadowPanel.
    public class TarjetaKPI_Emoji
    {
        // ======== PROPIEDADES =========
        public string NumeroTexto { get; set; }       // ← Para enlazar datos desde la BD
        public string Titulo { get; set; }
        public Color ColorIcono { get; set; }
        public string Emoji { get; set; }

        // ======== CONTROL PRINCIPAL =========
        public Guna2ShadowPanel PanelTarjeta { get; private set; }

        // ======== CONSTRUCTOR =========
        public TarjetaKPI_Emoji(string numero, string titulo, Color colorIcono, string emoji)
        {
            NumeroTexto = numero;
            Titulo = titulo;
            ColorIcono = colorIcono;
            Emoji = emoji;

            CrearTarjeta();
        }

        // ======== MÉTODO PRINCIPAL =========
        private void CrearTarjeta()
        {
            // 1. Base de la tarjeta
            PanelTarjeta = new Guna2ShadowPanel
            {
                Size = new Size(260, 110),
                FillColor = Color.White,
                Radius = 15,
                ShadowDepth = 50,
                ShadowColor = Color.Gainsboro,
                Margin = new Padding(20),
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };

            // 2. Fondo del icono
            Guna2Panel iconBg = new Guna2Panel
            {
                Size = new Size(60, 60),
                Location = new Point(20, 25),
                FillColor = ColorIcono,
                BorderRadius = 12
            };

            // 3. Emoji dentro del fondo
            Label lblEmoji = new Label
            {
                Text = Emoji,
                Font = new Font("Segoe UI Emoji", 26F, FontStyle.Regular),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // 4. Texto del número
            Label lblNumero = new Label
            {
                Text = NumeroTexto,
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(95, 25),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            // 5. Texto del título
            Label lblTitulo = new Label
            {
                Text = Titulo,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.DimGray,
                Location = new Point(95, 65),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            // Ensamblaje
            iconBg.Controls.Add(lblEmoji);
            PanelTarjeta.Controls.Add(iconBg);
            PanelTarjeta.Controls.Add(lblNumero);
            PanelTarjeta.Controls.Add(lblTitulo);

            // Eventos hover (aplican a todos los hijos también)
            AdjuntarEventosHover(PanelTarjeta);
        }

        // ======== EVENTOS DE HOVER =========
        private void AdjuntarEventosHover(Control card)
        {
            card.MouseEnter += Card_MouseEnter;
            card.MouseLeave += Card_MouseLeave;

            foreach (Control child in card.Controls)
            {
                child.MouseEnter += Card_MouseEnter;
                child.MouseLeave += Card_MouseLeave;

                if (child.HasChildren)
                {
                    foreach (Control grandChild in child.Controls)
                    {
                        grandChild.MouseEnter += Card_MouseEnter;
                        grandChild.MouseLeave += Card_MouseLeave;
                    }
                }
            }
        }

        private void Card_MouseEnter(object sender, EventArgs e)
        {
            Guna2ShadowPanel card = FindParentCard(sender as Control);
            if (card != null)
            {
                card.FillColor = Color.WhiteSmoke;
                card.ShadowDepth = 100;
            }
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            Guna2ShadowPanel card = FindParentCard(sender as Control);
            if (card != null)
            {
                Point mousePos = card.PointToClient(Cursor.Position);
                bool stillOver = card.ClientRectangle.Contains(mousePos);

                if (!stillOver)
                {
                    card.FillColor = Color.White;
                    card.ShadowDepth = 50;
                }
            }
        }

        private Guna2ShadowPanel FindParentCard(Control control)
        {
            Control current = control;
            while (current != null)
            {
                if (current is Guna2ShadowPanel panel)
                    return panel;

                current = current.Parent;
            }
            return null;
        }
    }
}
