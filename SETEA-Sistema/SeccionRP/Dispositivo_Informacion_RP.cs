using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Modelodb;
using SETEA_Sistema.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema.SeccionRP
{
        public partial class Dispositivo_Informacion_RP : MaterialForm
        {
                public Dispositivo_Informacion_RP() {
                        InitializeComponent();
                        var materialSkinManager = MaterialSkinManager.Instance;

                        materialSkinManager.AddFormToManage(this);

                        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                        materialSkinManager.ColorScheme = new ColorScheme(
                                    Primary.BlueGrey900,
                                    Primary.BlueGrey800,
                                    Primary.BlueGrey500,
                                    Accent.LightBlue200,
                                    TextShade.WHITE
                                );
                }

                private BindingList<Dispositivos_RP> DispositivosLSt = new BindingList<Dispositivos_RP>();

                private void ActualizarListaDeDispositivos() {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Dispositivos_RP.ToList();

                                        if (query == null)
                                        {
                                                MessageBox.Show("No se pudieron cargar los dispositivos");
                                                return;
                                        }

                                        DispositivosLSt.Clear();
                                        foreach (var item in query)
                                        {
                                                DispositivosLSt.Add(item);
                                        }

                                        InfoDispositivoDg.DataSource = DispositivosLSt;
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error: " + ex.Message + "\nDetalles: " + ex.InnerException?.Message);
                        }

                }

                private void Dispositivo_Informacion_RP_Load( object sender, EventArgs e ) {
                        CargarMarcas();
                        CargarTipos();
                        Configurador_DataGrid.ConfiguracionDelDataGrid(InfoDispositivoDg);
                        ActualizarListaDeDispositivos();
                }

                private void CargarTipos() {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Tipo_Dispositivos_RP.Select(x => new { x.Nombre_Tipo }).ToList();

                                        if (query == null)
                                        {
                                                MessageBox.Show("No se pudieron cargar las marcas");
                                                return;
                                        }
                                        foreach (var item in query)
                                        {
                                                TipoDispositivoCombobox.Items.Add(item.Nombre_Tipo);
                                        }
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al cargar los tipos: " + ex.Message);
                                return;
                        }
                }

                private void CargarMarcas() {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Marca_Del_Dispositivo_RP.Select(x => new { x.Nombre_De_La_Marca }).ToList();

                                        if (query == null)
                                        {
                                                MessageBox.Show("No se pudieron cargar las marcas");
                                                return;
                                        }
                                        foreach (var item in query)
                                        {
                                                MarcaCombobox.Items.Add(item.Nombre_De_La_Marca);
                                        }
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al cargar las marcas: " + ex.Message);
                                return;
                        }



                }

                private void materialCard1_Paint( object sender, PaintEventArgs e ) {

                }

                private void materialButton1_Click( object sender, EventArgs e ) {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var Mensage = MessageBox.Show("¿Deseas agregar el dispositivo?", "Guardar Dispositivo", MessageBoxButtons.YesNo);
                                        if (Mensage == DialogResult.No)
                                        {
                                                return;
                                        }

                                        var DispositivoTipoId = db.Tipo_Dispositivos_RP.FirstOrDefault(x => x.Nombre_Tipo == TipoDispositivoCombobox.Text);
                                        var DispositivoMarcaId = db.Marca_Del_Dispositivo_RP.FirstOrDefault(x => x.Nombre_De_La_Marca == MarcaCombobox.Text);

                                        var newDispositivo = new Dispositivo_Info_RP() {
                                                Tipo_Del_Dispositivo = DispositivoTipoId.ID_Tipo_Dispositivo,
                                                Marca_Del_Dispositivo = DispositivoMarcaId.ID_Marca_Dispositivo_RP,
                                        };

                                        var query = db.Dispositivo_Info_RP.FirstOrDefault(x => x.Marca_Del_Dispositivo == newDispositivo.Marca_Del_Dispositivo && x.Tipo_Del_Dispositivo == newDispositivo.Tipo_Del_Dispositivo);

                                        if(query == null)
                                        {
                                                db.SaveChanges(); // Aquí se guarda y se genera el ID

                                                IdRecienCreada.Text = newDispositivo.ID_Info_Dispositivo.ToString(); // Ahora puedes acceder al ID generado
                                                return;
                                        }
                                        MessageBox.Show("Ya existe un dispositivo con la misma marca y tipo");
                                        IdRecienCreada.Text = query.ID_Info_Dispositivo.ToString();
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al guardar el dispositivo: " + ex.Message);
                                return;
                        }
                }

                private void materialButton3_Click( object sender, EventArgs e ) {
                        var mensaje = MessageBox.Show("¿Deseas guardar los cambios?", "Guardar Dispositivo", MessageBoxButtons.YesNo);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }
                        try
                        {
                                if (idInfo == 0)
                                {
                                        MessageBox.Show("Primero debes de seleccionar un dispositvo de la tabla");
                                        return;
                                }
                                if (FalloEncontradoTxt.Text == "" || DescripcionDelClienteTxt.Text == "")
                                {
                                        MessageBox.Show("Primero debes de llenar todos los campos");
                                        return;
                                }
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var dispositivo = db.Dispositivos_RP.FirstOrDefault(x => x.ID_Dispositivo_RP == idInfo);
                                        if (dispositivo == null)
                                        {
                                                MessageBox.Show("No se ha encontrado el dispositivo");
                                                return;
                                        }

                                        dispositivo.Fallo_Encontrado_Del_Dispositivo = FalloEncontradoTxt.Text;
                                        dispositivo.Descripcion_Del_Problema_De_Parte_Del_Cliente = DescripcionDelClienteTxt.Text;
                                        dispositivo.Info_Dispositivo_ID = Convert.ToInt32(IdRecienCreada.Text);
                                        db.SaveChanges();
                                        ActualizarListaDeDispositivos();
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al guardar el dispositivo: " + ex.Message);
                                return;
                        }
                }
                int idInfo = 0;
                int idInfo_dis = 0;


                private void InfoDispositivoDg_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {


                                if (e.RowIndex >= 0)
                                {
                                        DataGridViewRow fila = InfoDispositivoDg.Rows[e.RowIndex];
                                        idInfo = Convert.ToInt32(fila.Cells[0].Value);
                                        FalloEncontradoTxt.Text = fila.Cells[1].Value.ToString();
                                        DescripcionDelClienteTxt.Text = fila.Cells[2].Value.ToString();
                                        idInfo_dis = Convert.ToInt32(fila.Cells[3].Value);
                                        IdRecienCreada.Text = idInfo_dis.ToString();
                                        if (idInfo == 0)
                                        {
                                                MessageBox.Show("No se ha seleccionado ninguna info...");
                                                return;
                                        }
                                        MessageBox.Show($"has Seleccionado la marca con el id :{idInfo}");
                                }
                        } catch (Exception)
                        {
                                MessageBox.Show("Error al seleccionar la info...");
                        }
                }

                private void materialButton2_Click( object sender, EventArgs e ) {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {

                                        if (IdRecienCreada.Text == "0")
                                        {
                                                MessageBox.Show("Primero debes de crear una info dispositivo ID...");
                                                return;
                                        }
                                        Dispositivos_RP dispositivo_new = new Dispositivos_RP();

                                        dispositivo_new.Descripcion_Del_Problema_De_Parte_Del_Cliente = DescripcionDelClienteTxt.Text;
                                        dispositivo_new.Fallo_Encontrado_Del_Dispositivo = FalloEncontradoTxt.Text;
                                        dispositivo_new.Info_Dispositivo_ID = Convert.ToInt32(IdRecienCreada.Text);
                                        dispositivo_new.Fecha_Recepcion = DateTime.Now;
                                        var Mensage = MessageBox.Show("¿Deseas agregar el dispositivo?", "Guardar Dispositivo", MessageBoxButtons.YesNo);
                                        if (Mensage == DialogResult.No)
                                        {
                                                return;
                                        }

                                        db.Dispositivos_RP.Add(dispositivo_new);
                                        db.SaveChanges();
                                        ActualizarListaDeDispositivos();
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al Agregar el dispositivo: " + ex.Message);
                                return;
                        }
                }
                private void ClearBoxes() {
                        FalloEncontradoTxt.Text = "";
                        DescripcionDelClienteTxt.Text = "";
                        IdRecienCreada.Text = "0";
                        idInfo = 0;
                        MarcaCombobox.Text = "";
                        TipoDispositivoCombobox.Text = "";
                }

                private void InfoDispositivoDg_DataError( object sender, DataGridViewDataErrorEventArgs e ) {

                }

                private void materialButton4_Click( object sender, EventArgs e ) {
                        var mensaje = MessageBox.Show("¿Deseas Eliminar la ifnormacion del dispositivo?", "Eliminar Dispositivo", MessageBoxButtons.YesNo);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        if (idInfo == 0)
                        {
                                MessageBox.Show("Primero debes de seleccionar un dispositvo de la tabla");
                                return;
                        }
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var dispositivo = db.Dispositivos_RP.FirstOrDefault(x => x.ID_Dispositivo_RP == idInfo);
                                        if (dispositivo == null)
                                        {
                                                MessageBox.Show("No se ha encontrado el dispositivo");
                                                return;
                                        }
                                        db.Dispositivos_RP.Remove(dispositivo);
                                        db.SaveChanges();
                                        ClearBoxes();
                                        ActualizarListaDeDispositivos();
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al eliminar el dispositivo: " + ex.Message);
                                return;
                        }
                }

                private void materialButton6_Click( object sender, EventArgs e ) {
                        ClearBoxes();
                }

                private void ProductoNombreFind_TextChanged( object sender, EventArgs e ) {
                        try
                        {
                                using(SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Dispositivos_RP.Where(x => x.Descripcion_Del_Problema_De_Parte_Del_Cliente.Contains(ProductoNombreFind.Text) || x.Fallo_Encontrado_Del_Dispositivo.Contains(ProductoNombreFind.Text)).ToList();
                                        DispositivosLSt.Clear();
                                        foreach (var item in query)
                                        {
                                                DispositivosLSt.Add(item);
                                        }
                                        InfoDispositivoDg.DataSource = DispositivosLSt;
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al buscar el dispositivo: " + ex.Message);
                                return;
                        }
                }

                private void materialButton7_Click( object sender, EventArgs e ) {
                    ActualizarListaDeDispositivos();
                }
                List<string> HeadersDispositivos = new List<string>();

                private void materialButton5_Click( object sender, EventArgs e ) {
                        var mensaje = MessageBox.Show("¿Deseas generar un reporte?", "Guardar Dispositivo", MessageBoxButtons.YesNo);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }
                        try
                        {
                                HeadersDispositivos.Add("ID");
                                HeadersDispositivos.Add("Fallo Encontrado");
                                HeadersDispositivos.Add("Descripcion Del Problema De Parte Del Cliente");
                                HeadersDispositivos.Add("Info Dispositivo ID");

                                GeneradorDePdf.GeneradorDePDFS(DispositivosLSt, HeadersDispositivos, "Dispositivos", "PlantillaDeDispositivos");
                                MessageBox.Show("Se ha generado el reporte de Dispositivos...");
                        } catch(Exception ex)
                        {
                                MessageBox.Show("Error al generar el reporte: " + ex.Message);
                                return;
                        }
                        
                }

                private void InfoDispositivoDg_CellContentClick( object sender, DataGridViewCellEventArgs e ) {

                }
        }
}
