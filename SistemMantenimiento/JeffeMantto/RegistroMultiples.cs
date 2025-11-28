using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;



namespace SistemMantenimiento.JeffeMantto
{
    public partial class RegistroMultiples : Form
    {
        public RegistroMultiples()
        {

            InitializeComponent();
            txb_nombrePM.Enabled = false;

        }
        private void extraer_archivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar archivo PDF";
            openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                // Mostrar solo el nombre
                txb_nombre_archivo.Text = Path.GetFileName(rutaArchivo);

                // Cargar PDF usando PdfiumViewer
                PdfDocument pdf = PdfDocument.Load(rutaArchivo);
                PdfViewer viewer = new PdfViewer();
                viewer.Document = pdf;
                viewer.Dock = DockStyle.Fill;

                panel_pdf.Controls.Clear();
                panel_pdf.Controls.Add(viewer);
            }
        }


        private void btn_habilitar_pm_Click(object sender, EventArgs e)
        {

            if (txb_nombrePM.Enabled == true)
            {
                txb_nombrePM.Enabled = false;
                btn_habilitar_pm.Text = "Habilitar PM";
                return;
            }
            if (txb_nombrePM.Enabled == false)
            {
                txb_nombrePM.Enabled = true;
                btn_habilitar_pm.Text = "Deshabilitar PM";

                return;
            }
        }
        

        private void btn_agregar_pm_Click(object sender, EventArgs e)
        {
            string nombrePM = txb_nombrePM.Text; 

            if (string.IsNullOrEmpty(nombrePM))
            {
                MessageBox.Show("Advertencia", "No pueden haber campos vacios", MessageBoxButtons.OK);
                return; 
            }
        }

        private void btn_registrar_pm_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo_flota = txb_codigo_flota.Text;
                float horometro = float.Parse(txb_horometro.Text);
                int id_equipo = int.Parse(txb_id.Text);
                string nombre_archivo = txb_nombre_archivo.Text;

                if (string.IsNullOrEmpty(codigo_flota) || string.IsNullOrEmpty(txb_horometro.Text)
                    || string.IsNullOrEmpty(txb_id.Text) || string.IsNullOrEmpty(nombre_archivo))
                {
                    MessageBox.Show("Advertencia", "No pueden haber campos vacios", MessageBoxButtons.OK);
                    return;
                }
                //capa logica
                //capa entidad
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el PM:\n" +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_subir_hr_Click(object sender, EventArgs e)
        {
            try
            {
                extraer_archivo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al seleccionar el archivo:\n" + 
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

    }
}
