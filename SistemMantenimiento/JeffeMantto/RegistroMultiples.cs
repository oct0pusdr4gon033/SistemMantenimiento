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
using CapaLogica.Producto;



namespace SistemMantenimiento.JeffeMantto
{
    public partial class RegistroMultiples : Form
    {
        public RegistroMultiples()
        {

            InitializeComponent();
            txb_nombrePM.Enabled = false;
            txb_id_area.Enabled = false;
            txb_id_marca.Enabled = false;
            txb_id_tipo_equipo.Enabled = false; 
            
        }
        private void RegistroMultiples_Load(object sender, EventArgs e)
        {
            cargarAreasdgv();
            cargarMarcadgv();
            cargarModelodgv();
            cargarTipoEquipodgv();
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

                entArea editar_area = new entArea();
                editar_area.id_area = int.Parse(txb_id_area.Text);
                editar_area.nombre_area = txb_nombre_area.Text.Trim().ToUpper();
                logArea.Instancia.EditarArea(editar_area);
                DialogResult r = MessageBox.Show(
                    "¿Estas seguro de editar esta area?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show(
                        "Área editada con éxito",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    btn_edicion_area.Text = "Habilitar Edicion";
                    cargarAreasdgv();
                    dgv_area.Refresh();
                    txb_id_area.Clear();
                    txb_nombre_area.Clear();
                }
                else
                {
                    return;
                }
              
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
            txb_id_area.Text = fila.Cells["id_area"].Value.ToString();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txb_id_area.Text);
            try
            {
                logArea.Instancia.EliminarArea(id);
                MessageBox.Show(
                   "Se elimino el registro con exito",
                   "Información",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                cargarTipoEquipodgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Este campo esta relacionado en uno o mas campos de otra tabla " + ex.Message,
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    
                );
            }
        }
        public void cargarMarcadgv()
        {
            List<entMarca> listaMarcas = logMarca.Instancia.ListarMarcas();
            dgv_Marca.DataSource = null;
            dgv_Marca.AutoGenerateColumns = true;   // Permite que aparezcan las propiedades
            dgv_Marca.DataSource = listaMarcas;

            dgv_Marca.Columns["id_marca"].HeaderText = "ID";
            dgv_Marca.Columns["nombre_marca"].HeaderText = "NOMBRE";

        }
        public void cargarModelodgv()
        {
            // 1. Obtener lista
            List<entModelo> listaModelos = logModelo.Instancia.ListarModelos();

            // 2. Limpiar
            dgv_modelo.DataSource = null;

            // 3. Asignar origen
            dgv_modelo.AutoGenerateColumns = true;
            dgv_modelo.DataSource = listaModelos;

            // 4. PERSONALIZAR ENCABEZADOS Y ORDEN
            // Asegúrate que estos nombres coinciden con tu clase entModelo
            if (dgv_modelo.Columns["id_modelo_equipo"] != null)
            {
                dgv_modelo.Columns["id_modelo_equipo"].HeaderText = "ID MODELO";
                dgv_modelo.Columns["id_modelo_equipo"].DisplayIndex = 0;
                dgv_modelo.Columns["id_modelo_equipo"].Width = 90;
            }

            if (dgv_modelo.Columns["id_marca"] != null)
            {
                dgv_modelo.Columns["id_marca"].HeaderText = "ID MARCA";
                dgv_modelo.Columns["id_marca"].DisplayIndex = 1;
                dgv_modelo.Columns["id_marca"].Width = 90;
            }

            if (dgv_modelo.Columns["nombre_marca"] != null)
            {
                dgv_modelo.Columns["nombre_marca"].HeaderText = "NOMBRE MARCA";
                dgv_modelo.Columns["nombre_marca"].DisplayIndex = 2;
                dgv_modelo.Columns["nombre_marca"].Width = 150;
            }

            if (dgv_modelo.Columns["nombre_modelo"] != null)
            {
                dgv_modelo.Columns["nombre_modelo"].HeaderText = "NOMBRE MODELO";
                dgv_modelo.Columns["nombre_modelo"].DisplayIndex = 3;
                dgv_modelo.Columns["nombre_modelo"].Width = 170;
            }
        }

        private void btn_agregar_marca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_marca.Text))
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
                                "¿Estas seguro que quieres agregar esta marca?",
                                "Advertencia",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information
                            );
            if (r == DialogResult.Yes)
            {
                string nombre_marca = txb_marca.Text;
                nombre_marca = nombre_marca.Trim().ToUpper();
                entMarca marca = new entMarca();
                marca.nombre_marca = nombre_marca;
                entMarca resultado = logMarca.Instancia.InsertarMarca(marca);
                MessageBox.Show(
                    "Marca agregada con éxito",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                txb_marca.Clear();
                cargarMarcadgv();
            }else
            {
                return; 
            }

        }

        private void dgv_Marca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Evitar errores si se hace clic en el encabezado de la tabla
            if (e.RowIndex < 0)
                return;

            // 2. Obtener la fila seleccionada actual
            DataGridViewRow fila = dgv_Marca.Rows[e.RowIndex];
            if (fila.Cells["id_marca"].Value != null)
            {
               txb_id_marca.Text = fila.Cells["id_marca"].Value.ToString();
            }
            if (fila.Cells["nombre_marca"].Value!=null)
            {
                txb_marca.Text = fila.Cells["nombre_marca"].Value.ToString();
            }
        }

        private void btn_agregar_modelo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_modelo.Text)|| string.IsNullOrEmpty(txb_id_marca.Text))
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
                                "¿Estas seguro que quieres agregar este modelo?",
                                "Advertencia",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information
                            );
            if (r == DialogResult.Yes)
            {
                string nombre_modelo = txb_modelo.Text;
                int id_marca = int.Parse(txb_id_marca.Text);
                nombre_modelo = nombre_modelo.Trim().ToUpper();
                entModelo modelo = new entModelo();
                modelo.nombre_modelo = nombre_modelo;
                modelo.id_marca = id_marca;
                entModelo resultado = logModelo.Instancia.InsertarModelo(modelo);
                MessageBox.Show(
                    "Modelo agregado con éxito",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                txb_modelo.Clear();
                cargarModelodgv();
            }
        }

        private void btn_buscar_marca_modelo_Click(object sender, EventArgs e)
        {
            string opcion = cmb_buscar_marca_modelo.SelectedItem.ToString();
            string busqueda = txb_buscar_modelo_marca.Text.Trim().ToUpper();
            busqueda= busqueda.Trim().ToUpper();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show(
                    "El campo de Buscar esta vacio",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; 
            }
            if (opcion =="Marca")
            {
                List<entMarca> marcaBuscada = logMarca.Instancia.BuscarMarca(busqueda);
                dgv_Marca.DataSource = null;
                dgv_Marca.AutoGenerateColumns = true;
                dgv_Marca.DataSource = marcaBuscada;

                // (opcional) Renombrar columnas si es necesario
                if (dgv_Marca.Columns["id_marca"] != null)
                    dgv_Marca.Columns["id_marca"].HeaderText = "ID";

                if (dgv_Marca.Columns["nombre_marca"] != null)
                    dgv_Marca.Columns["nombre_marca"].HeaderText = "NOMBRE";
                return; 
            }
            if (opcion == "Modelo")
            {
                List<entModelo> modelo_buscado =logModelo.Instancia.BuscarModelo(busqueda);
                
                return; 
            }

            
        }

        private void dgv_modelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Evitar errores si se hace clic en el encabezado de la tabla
            if (e.RowIndex < 0)
                return;

            // 2. Obtener la fila seleccionada actual
            DataGridViewRow fila = dgv_modelo.Rows[e.RowIndex];

            // 3. Pasar los datos simples a los TextBoxes
            // (Asegúrate que los nombres "id_modelo", "nombre_modelo" coincidan con los de tu clase entModelo)
            txb_id_modelo.Text = fila.Cells["id_modelo_equipo"].Value.ToString();
            txb_modelo.Text = fila.Cells["nombre_modelo"].Value.ToString();
            txb_marca.Text = fila.Cells["nombre_marca"].Value.ToString();
            // 4. IMPORTANTE: Sincronizar el ComboBox de Marca
            // Si estás editando, necesitas que el ComboBox (cbo_marca) muestre la marca de ese modelo.
            // Usamos 'id_marca' que es el valor oculto (ValueMember) del ComboBox.
            if (fila.Cells["id_marca"].Value != null)
            {
                txb_id_marca.Text = fila.Cells["id_marca"].Value.ToString();
            }
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            string opcion = cmb_buscar_marca_modelo.SelectedItem.ToString();
            
            if (opcion == "Marca")
            {
                DialogResult r= MessageBox.Show(
                    "¿Estas seguro que quieres eliminar esta marca?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );
                if (r==DialogResult.Yes)
                {
                    logMarca.Instancia.EliminarMarca(int.Parse(txb_id_marca.Text));
                    MessageBox.Show(
                       "Se elimino el registro con exito",
                       "Información",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                       );
                    cargarMarcadgv();
                    return;
                } else
                {
                    return; 
                }
            }

            if (opcion == "Modelo")
            {
                DialogResult r = MessageBox.Show(
                    "¿Estas seguro que quieres eliminar este modelo?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (r== DialogResult.Yes)
                {
                    logModelo.Instancia.EliminarModelo(int.Parse(txb_id_modelo.Text));
                    MessageBox.Show(
                        "Se elimino el registro con exito",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    cargarModelodgv();
                    return;
                } else
                {
                    return; 
                }
               
            }
        }

        private void btn_habiitar_marca_modelo_Click(object sender, EventArgs e)
        {
            string texto= btn_habiitar_marca_modelo.Text;
           
            // Primero verificamos el índice
            if (cmb_buscar_marca_modelo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione una opción en el combobox",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Detiene la ejecución aquí
            }

            string opcion = cmb_buscar_marca_modelo.SelectedItem.ToString();

            if (texto=="Habilitar Edicion")
            {
                btn_habiitar_marca_modelo.Text = "Editar";
                return;
            }

            if (texto == "Editar" && opcion=="Marca")
            {
                DialogResult r = MessageBox.Show(
                    "¿Estas seguro de editar esta marca?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );
                if (r==DialogResult.Yes)
                {
                    entMarca marca = new entMarca();
                    marca.id_marca = int.Parse(txb_id_marca.Text);
                    marca.nombre_marca = txb_marca.Text.Trim().ToUpper();
                    logMarca.Instancia.EditarMarca(marca);
                    MessageBox.Show(
                        "Se realizo el cambio con exito",
                        "Informacion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    cargarMarcadgv();
                    return;

                } else
                {
                    return; 
                }

            }

            if (texto == "Editar" && opcion == "Modelo")
            {
                DialogResult r = MessageBox.Show(
                    "¿Estas seguro de editar el modelo?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );
                if (r == DialogResult.Yes)
                {
                    entModelo modelo = new entModelo();
                    modelo.id_modelo_equipo = int.Parse(txb_id_modelo.Text);
                    modelo.nombre_modelo = txb_modelo.Text.Trim().ToUpper();

                    // --- AGREGA ESTA LÍNEA OBLIGATORIAMENTE ---
                    // Debes decirle a la base de datos a qué marca pertenece este modelo.
                    // Asegúrate de usar el nombre correcto de tu ComboBox de marcas.
                    modelo.id_marca = int.Parse(txb_id_marca.Text);
                    // ------------------------------------------

                    // OJO: Verifica que tu método en Logica se llame EditarMarca o EditarModelo
                    // Según tu código anterior era EditarMarca recibiendo un modelo.
                    logModelo.Instancia.EditarMarca(modelo);

                    MessageBox.Show(
                        "Se realizo el cambio con exito",
                        "Informacion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    cargarModelodgv();
                    return;

                }
                else
                {
                    return;
                }
            }
        }

        public void cargarTipoEquipodgv()
        {
            // Cargar lista
            List<entTipoEquipo> listarTipoEquipo = logTipoEquipo.Instancia.ListarTipoEquipo();

            dgv_tipo_equipo.DataSource = null;
            dgv_tipo_equipo.AutoGenerateColumns = true;   // Permite que aparezcan las propiedades
            dgv_tipo_equipo.DataSource = listarTipoEquipo;

            // Cambiar encabezados
            dgv_tipo_equipo.Columns["id_tipo_equipo"].HeaderText = "ID";
            dgv_tipo_equipo.Columns["nombre_tipo_equipo"].HeaderText = "NOMBRE";
        }

        private void btn_agregar_tipo_equipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_tipo_equipo.Text))
            {
                MessageBox.Show(

                    "No se puede agregar un equipo vacio",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return; 
            }

            DialogResult r = MessageBox.Show(
                                "¿Estas seguro que quieres agregar este tipo de equipo?",
                                "Advertencia",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information
                            );

            if (r==DialogResult.Yes)
            {
                string tipo_equipo = txb_tipo_equipo.Text;
                tipo_equipo = tipo_equipo.Trim().ToUpper();
                entTipoEquipo tipoEquipo = new entTipoEquipo();
                tipoEquipo.nombre_tipo_equipo = tipo_equipo;
                entTipoEquipo resultado = logTipoEquipo.Instancia.InsertarTipoEquipo(tipoEquipo);
                cargarTipoEquipodgv();
                MessageBox.Show(
                    "Tipo de equipo agregado con éxito",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
        }

        private void btn_buscar_eqp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_buscar_tipo.Text))
            {
                MessageBox.Show(
                    "El campo de Buscar esta vacio",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            string buscar_tipo = txb_buscar_tipo.Text;
            buscar_tipo = buscar_tipo.Trim().ToUpper();
            List<entTipoEquipo> tipoEquipoBuscado = logTipoEquipo.Instancia.BuscarTipoEquipo(buscar_tipo);
            // Mostrar resultado
            dgv_tipo_equipo.DataSource = null;
            dgv_tipo_equipo.AutoGenerateColumns = true;
            dgv_tipo_equipo.DataSource = tipoEquipoBuscado;

            // (opcional) Renombrar columnas si es necesario
            if (dgv_tipo_equipo.Columns["id_tipo_equipo"] != null)
                dgv_tipo_equipo.Columns["id_tipo_equipo"].HeaderText = "ID";

            if (dgv_tipo_equipo.Columns["nombre_tipo_equipo"] != null)
                dgv_tipo_equipo.Columns["nombre_tipo_equipo"].HeaderText = "NOMBRE";

        }

        private void dgv_tipo_equipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Evitar errores si se hace clic en el encabezado de la tabla
            if (e.RowIndex < 0)
                return;

            // 2. Obtener la fila seleccionada actual
            DataGridViewRow fila = dgv_tipo_equipo.Rows[e.RowIndex];
            if (fila.Cells["id_tipo_equipo"].Value != null)
            {
                txb_id_tipo_equipo.Text = fila.Cells["id_tipo_equipo"].Value.ToString();
            }
            if (fila.Cells["nombre_tipo_equipo"].Value != null)
            {
                txb_tipo_equipo.Text = fila.Cells["nombre_tipo_equipo"].Value.ToString();
            }
        }

        private void btn_editar_eqp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_tipo_equipo.Text))
            {
                MessageBox.Show(
                    "No se puede editar un campo nulo",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string texto_btn = btn_editar_eqp.Text;

            if (texto_btn == "Habilitar Edicion")
            {
                btn_editar_eqp.Text = "Editar";
                return;
            }
          
            if (texto_btn == "Editar")
            {
                DialogResult r = MessageBox.Show(
                    "¿Estas seguro de editar esta area?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (r == DialogResult.Yes)
                {
                    entTipoEquipo editar_tipo = new entTipoEquipo();
                    editar_tipo.id_tipo_equipo = int.Parse(txb_id_tipo_equipo.Text);
                    editar_tipo.nombre_tipo_equipo = txb_tipo_equipo.Text.Trim().ToUpper();
                    logTipoEquipo.Instancia.EditarTipoEquipo(editar_tipo);
                    MessageBox.Show(
                        "Área editada con éxito",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    btn_editar_eqp.Text = "Habilitar Edicion";
                    cargarTipoEquipodgv();
                    txb_tipo_equipo.Clear();
                }
                else
                {
                    return;
                }

            }
        }

        private void btn_eliminar_tipo_eqp_Click(object sender, EventArgs e)
        {
            // 1. VALIDACIÓN: Verificar que haya un ID escrito
            if (string.IsNullOrEmpty(txb_id_tipo_equipo.Text))
            {
                MessageBox.Show("Seleccione primero un registro de la tabla para eliminar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. CONFIRMACIÓN: Preguntar al usuario (¡Vital para eliminar!)
            DialogResult pregunta = MessageBox.Show("¿Está seguro de eliminar este Tipo de Equipo?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txb_id_tipo_equipo.Text);

                    // 3. EJECUCIÓN: Llamar a la capa lógica
                    bool exito = logTipoEquipo.Instancia.EliminarTipoEquipo(id);

                    if (exito)
                    {
                        MessageBox.Show("Registro eliminado correctamente.",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 4. LIMPIEZA Y ACTUALIZACIÓN
                        cargarTipoEquipodgv(); // Recargar la tabla para ver que desapareció
                        limpiarCampos();       // Método para borrar las cajas de texto (si lo tienes)
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Esto captura errores de SQL (ej: Si el tipo está siendo usado en otra tabla)
                    MessageBox.Show("Ocurrió un error al eliminar: " + ex.Message,
                                    "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void limpiarCampos()
        {
            txb_id_tipo_equipo.Text = "";
            txb_tipo_equipo.Text = ""; // O como se llame tu caja de nombre
        }
    }
}
