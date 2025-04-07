using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Modelodb;
using SETEA_Sistema.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema.SeccionRP
{
        public partial class Tipo_De_Dispositivo_Show_RP : MaterialForm
        {

                BindingList<Tipo_Dispositivos_RP> TiposLST = new BindingList<Tipo_Dispositivos_RP>();
                public Tipo_De_Dispositivo_Show_RP() {
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

                private void Tipo_De_Dispositivo_Show_RP_Load( object sender, EventArgs e ) {
                        Configurador_DataGrid.ConfiguracionDelDataGrid(MyTiposDG);
                        ActualizarTablaTipos();

                }

                private void ActualizarTablaTipos() {
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                var query = db.Tipo_Dispositivos_RP.ToList();
                                TiposLST.Clear();
                                foreach (var item in query)
                                {
                                        TiposLST.Add(item);
                                }
                                MyTiposDG.DataSource = TiposLST;
                        }
                }
                int idTipo = 0;
                string NombreTipo = "";
                private void MyTiposDG_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {


                                if (e.RowIndex >= 0)
                                {

                                        DataGridViewRow fila = MyTiposDG.Rows[e.RowIndex];


                                        idTipo = Convert.ToInt32(fila.Cells[0].Value);
                                        NombreTipo = fila.Cells[1].Value.ToString();
                                        if (NombreTipo == "")
                                        {
                                                MessageBox.Show("No se ha seleccionado ningun Tipo de dispositivo...");
                                                return;
                                        }
                                        NombreTipoTxt.Text = NombreTipo;
                                        MessageBox.Show($"has Seleccionado el Tipo de dispositivo con el id :{idTipo}");
                                }

                        } catch (Exception)
                        {
                                MessageBox.Show("Error al seleccionar la marca...");
                        }
                }

                private void MyTiposDG_DataError( object sender, DataGridViewDataErrorEventArgs e ) {

                }

                private void AgregarMarca_Click( object sender, EventArgs e ) {

                        try
                        {
                                if (NombreTipoTxt.Text == "")
                                {
                                        MessageBox.Show("No se puede agregar un tipo de dispositivo vacio...");
                                        return;
                                }
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Tipo_Dispositivos_RP.FirstOrDefault(x => x.Nombre_Tipo == NombreTipoTxt.Text);
                                        if (query != null)
                                        {
                                                MessageBox.Show("Ya existe un tipo de dispositivo con ese nombre...");
                                                return;
                                        }
                                        Tipo_Dispositivos_RP tipo = new Tipo_Dispositivos_RP();
                                        tipo.Nombre_Tipo = NombreTipoTxt.Text;
                                        db.Tipo_Dispositivos_RP.Add(tipo);
                                        db.SaveChanges();
                                        ActualizarTablaTipos();
                                }
                        } catch (Exception)
                        {
                                MessageBox.Show("No se pudo agregar el tipo de dispositivo");
                        }

                }

                private void materialButton1_Click( object sender, EventArgs e ) {
                        try
                        {
                                var message = MessageBox.Show("Deseas eliminar el tipo de dispositivo?", "Eliminar Marca", MessageBoxButtons.YesNo);
                                if (message == DialogResult.No)
                                {
                                        return;
                                }

                                if (ValidarID())
                                {

                                        return;
                                }

                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Tipo_Dispositivos_RP.FirstOrDefault(x => x.ID_Tipo_Dispositivo == idTipo);
                                        db.Tipo_Dispositivos_RP.Remove(query);
                                        db.SaveChanges();
                                        ActualizarTablaTipos();
                                }
                        } catch (Exception)
                        {
                                MessageBox.Show("No se pudo Eliminar el tipo de dispositivo");
                                return;
                        }
                }
                private bool ValidarID() {
                        if (idTipo == 0)
                        {
                                MessageBox.Show("No se ha seleccionado ningun tipo de dispositivo...");
                                return true;
                        }
                        return false;
                }

                private void materialButton2_Click( object sender, EventArgs e ) {
                        try
                        {
                                var message = MessageBox.Show("Deseas Eliminar el tipo de dispositivo?", "Actualizar Marca", MessageBoxButtons.YesNo);

                                if (message == DialogResult.No)
                                {
                                        return;
                                }

                                if (ValidarID())
                                {
                                        return;
                                }

                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Tipo_Dispositivos_RP.FirstOrDefault(x => x.ID_Tipo_Dispositivo == idTipo);
                                        if(query == null)
                                        {
                                                MessageBox.Show("No se ha encontrado ningun tipo de dispositivo...");
                                                return;
                                        }
                                        query.Nombre_Tipo = NombreTipoTxt.Text;
                                        db.SaveChanges();
                                        ActualizarTablaTipos();
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("No se pudo actualizar el tipo de dispositivo");
                        }
                }

                List<string> HeadersTipos = new List<string>();
                private void materialButton3_Click( object sender, EventArgs e ) {
                        HeadersTipos.Add("ID");
                        HeadersTipos.Add("Nombre Tipo");
                        HeadersTipos.Add("Dispositivos");

                        var message = MessageBox.Show("Deseas Realizar un reporte de Tipos de Dispositivos?", "Salir", MessageBoxButtons.YesNo);
                        if(message == DialogResult.No)
                        {
                                return;
                        }
                        GeneradorDePdf.GeneradorDePDFS(TiposLST, HeadersTipos, "Tipos", "PlantillaDeTipos");
                        MessageBox.Show("Se ha generado el reporte de Tipos de Dispositivos...");
                }
        }
}
