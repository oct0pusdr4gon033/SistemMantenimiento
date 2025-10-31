using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad.Equipo; 

namespace SistemMantenimiento.JeffeMantto
{
    public partial class AgregarEquipos : Form
    {
        public AgregarEquipos()
        {
            InitializeComponent();
            top_cinco(flp_top);
        }
        public void top_cinco(FlowLayoutPanel flp_top_cinco)
        {
            // 1. (Recomendado) Limpia el panel antes de añadir nuevos controles
            flp_top_cinco.Controls.Clear();

            // 2. Asegúrate de que apile los controles verticalmente
            flp_top_cinco.FlowDirection = FlowDirection.TopDown;

            // (Opcional) Añade un poco de relleno interno
            flp_top_cinco.Padding = new Padding(10);

            for (int i = 1; i <= 5; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl_top_" + i;
                lbl.BackColor = Color.Red;
                lbl.Size = new Size(150, 30); // El FlowLayoutPanel respetará este tamaño
                lbl.Text = "Top " + i;
                lbl.ForeColor = Color.White;
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                // (Opcional) Añade un margen para separarlos
                lbl.Margin = new Padding(0, 0, 0, 5);

                // 3. Añade el Label al FlowLayoutPanel
                // ¡Él se encargará de la posición automáticamente!
                flp_top_cinco.Controls.Add(lbl);
            }



        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string codigo = txb_codigo_flota.Text;
            string marca = cmb_tipo_equipo.GetItemText(cmb_tipo_equipo.SelectedItem);
            string modelo = txb_modelo.Text;
            string num_serie = txb_numero_serie.Text;
            string tipo_equipo = cmb_tipo_equipo.GetItemText(cmb_tipo_equipo.SelectedItem);
            int anio_fabricacion = int.Parse(txb_anio_fabricacion.Text);
            int horometro_inicial= int.Parse(txb_horometro_inicial.Text);
            int horometro_actual= int.Parse(txb_horometro_actual.Text);
            DateTime dtp= dtp_fecha.Value;
            string estado = cmb_estado.GetItemText(cmb_estado.SelectedItem);
            string imagen = pb_agregar_imagen.Text;

            entEquipo nuevoEquipo = new entEquipo()
            {
                codigo_flota = codigo,
                marca = marca,
                modelo = modelo,
                serie = num_serie,
                tipo_equipo = tipo_equipo,
                anio_fabricacion = anio_fabricacion,
                horometro_inicial = horometro_inicial,
                horometro_actual = horometro_actual,
                fecha_registro = dtp,
                imagen_equipo = imagen,
                estado_equipo = estado
            };

        }
    }
}
