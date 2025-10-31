using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemMantenimiento.FuncionesAuxiliares
{
    public static class AvatarRenderer
    {
        /// <summary>
        /// Dibuja un avatar circular con las iniciales centradas dentro del panel.
        /// </summary>
        /// <param name="panel">Panel donde se dibujará el avatar.</param>
        /// <param name="e">Evento Paint del panel.</param>
        /// <param name="inicialesUsuario">Iniciales del usuario a mostrar.</param>
        /// <param name="diametro">Tamaño del círculo (por defecto 70).</param>
        /// <param name="colorFondo">Color de fondo del círculo (por defecto violeta suave).</param>
        public static void DibujarAvatar(Panel panel, PaintEventArgs e, string inicialesUsuario,
                                         int diametro = 70, Color? colorFondo = null)
        {
            if (panel == null || e == null || string.IsNullOrEmpty(inicialesUsuario))
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 1️⃣ Determinar color base
            Color fondo = colorFondo ?? Color.FromArgb(147, 112, 219);

            // 2️⃣ Calcular la posición para centrar el círculo
            int x = (panel.Width - diametro) / 2;
            int y = (panel.Height - diametro) / 2;
            Rectangle rect = new Rectangle(x, y, diametro, diametro);

            // 3️⃣ Dibujar círculo
            using (SolidBrush brush = new SolidBrush(fondo))
                g.FillEllipse(brush, rect);

            // 4️⃣ Dibujar texto centrado
            using (Font fuente = new Font("Segoe UI", 14, FontStyle.Bold))
            using (Brush textoBrush = new SolidBrush(Color.White))
            {
                SizeF textoSize = g.MeasureString(inicialesUsuario, fuente);
                float tx = (panel.Width - textoSize.Width) / 2;
                float ty = (panel.Height - textoSize.Height) / 2;
                g.DrawString(inicialesUsuario, fuente, textoBrush, tx, ty);
            }
        }
    }
}
