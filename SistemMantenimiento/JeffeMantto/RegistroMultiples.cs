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
using CapaEntidad;
using CapaLogica;
using CapaEntidad.Equipo;
using CapaLogica.Equipo;



namespace SistemMantenimiento.JeffeMantto
{
    public partial class RegistroMultiples : Form
    {
        public RegistroMultiples()
        {

            InitializeComponent();
            txb_nombrePM.Enabled = false;

        }
        private void RegistroMultiples_Load(object sender, EventArgs e)
        {
            cargarAreasdgv();
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

        //BTN AGREGAR AREA-----
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_nombre_area.Text))
            {
                MessageBox.Show(
                    "No se puede agregar un campo nulo",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            DialogResult r = MessageBox.Show(
                                "¿Estas seguro que quieres agregar esta area?",
                                "Advertencia",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information
                            );

            if (r == DialogResult.Yes)
            {
                string nombre_area = txb_nombre_area.Text;
                nombre_area = nombre_area.Trim().ToUpper();
                entArea area = new entArea();
                area.nombre_area = nombre_area;
                entArea resultado = logArea.Instancia.InsertarArea(area);
                MessageBox.Show(
                    "Área agregada con éxito",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                cargarAreasdgv();
            }
            else
            {
                return;
            }
        }
    
        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            string texto_btn= btn_edicion_area.Text;

            if (texto_btn=="Habilitar Edicion")
            {
                btn_edicion_area.Text = "Editar";
                return;
            }

            if (texto_btn=="Editar")
            {


            }
            


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_buscar_area.Text))
            {
                MessageBox.Show(
                    "El campo de Buscar esta vacio",
                    "Advertencia", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; 
            }
            string area = txb_buscar_area.Text;
            area=area.Trim().ToUpper();
            List<entArea> areaBuscada= logArea.Instancia.BuscarArea(area);
            // Mostrar resultado
            dgv_area.DataSource = null;
            dgv_area.AutoGenerateColumns = true;
            dgv_area.DataSource = areaBuscada;

            // (opcional) Renombrar columnas si es necesario
            if (dgv_area.Columns["id_area"] != null)
                dgv_area.Columns["id_area"].HeaderText = "ID";

            if (dgv_area.Columns["nombre_area"] != null)
                dgv_area.Columns["nombre_area"].HeaderText = "NOMBRE";


        }
        public void cargarAreasdgv()
        {
            // Cargar lista
            List<entArea> listaAreas = logArea.Instancia.ObtenerAreas();

            dgv_area.DataSource = null;
            dgv_area.AutoGenerateColumns = true;   // Permite que aparezcan las propiedades
            dgv_area.DataSource = listaAreas;

            // Cambiar encabezados
            dgv_area.Columns["id_area"].HeaderText = "ID";
            dgv_area.Columns["nombre_area"].HeaderText = "NOMBRE";
        }

        private void dgv_area_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores cuando se hace clic en el encabezado
            if (e.RowIndex < 0)
                return;

            // Obtener fila seleccionada
            DataGridViewRow fila = dgv_area.Rows[e.RowIndex];

            // Extraer nombre y mostrarlo en el textbox
            txb_nombre_area.Text = fila.Cells["nombre_area"].Value.ToString();

        }
    }
}
