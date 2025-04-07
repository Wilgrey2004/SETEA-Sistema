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
        public partial class Marcas_RP_Show : MaterialForm
        {
                BindingList<Marca_Del_Dispositivo_RP> MarcasLST = new BindingList<Marca_Del_Dispositivo_RP>();
                public Marcas_RP_Show() {
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

                private void Marcas_RP_Load( object sender, EventArgs e ) {
                        MyMarcasDG.DataSource = MarcasLST;
                        CargarListADeMarcas();
                        Configurador_DataGrid.ConfiguracionDelDataGrid(MyMarcasDG);
                }

                private void CargarListADeMarcas() {
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                var Marcas = db.Marca_Del_Dispositivo_RP
                                        .ToList();
                                MarcasLST.Clear();
                                foreach (var item in Marcas)
                                {
                                        MarcasLST.Add(item);
                                }
                                MyMarcasDG.DataSource = MarcasLST;
                        }
                }

                private void AgregarMarca_Click( object sender, EventArgs e ) {
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                if (NombreDeLasMarcas.Text == "")
                                {
                                        MessageBox.Show("No se puede agregar una marca vacia...");
                                        return;
                                }
                                try
                                {
                                        var query = db.Marca_Del_Dispositivo_RP.FirstOrDefault(x => x.Nombre_De_La_Marca == NombreDeLasMarcas.Text);
                                        if(query == null)
                                        {
                                                MessageBox.Show("Ya existe una marca con ese nombre...");
                                                return;
                                        }
                                        Marca_Del_Dispositivo_RP marca = new Marca_Del_Dispositivo_RP();
                                        marca.Nombre_De_La_Marca = NombreDeLasMarcas.Text;
                                        db.Marca_Del_Dispositivo_RP.Add(marca);
                                        db.SaveChanges();
                                        CargarListADeMarcas();
                                } catch (Exception)
                                {
                                        MessageBox.Show("No se pudo agregar la marca error agregando...");
                                }
                                

                        }
                }
                int idMarca = 0;
                string NombreMarca = "";
                private void MyMarcasDG_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {


                                if (e.RowIndex >= 0)
                                {

                                        DataGridViewRow fila = MyMarcasDG.Rows[e.RowIndex];


                                        idMarca = Convert.ToInt32(fila.Cells[0].Value);
                                        NombreMarca = fila.Cells[1].Value.ToString();
                                        if (NombreMarca == "")
                                        {
                                                MessageBox.Show("No se ha seleccionado ninguna marca...");
                                                return;
                                        }
                                        NombreDeLasMarcas.Text = NombreMarca;
                                        MessageBox.Show($"has Seleccionado la marca con el id :{idMarca}");
                                }

                        } catch (Exception)
                        {
                                MessageBox.Show("Error al seleccionar la marca...");
                        }

                }

                private void materialButton2_Click( object sender, EventArgs e ) {
                         if (idMarca == 0)
                        {
                                MessageBox.Show("No se ha seleccionado ninguna marca...");
                                return;
                        }

                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                try
                                {
                                        var Marca = db.Marca_Del_Dispositivo_RP
                                                .FirstOrDefault(x => x.ID_Marca_Dispositivo_RP == idMarca);
                                        Marca.Nombre_De_La_Marca = NombreDeLasMarcas.Text;
                                        var message = MessageBox.Show("Deseas actualizar la marca?", "Actualizar Marca", MessageBoxButtons.YesNo);
                                        if (message == DialogResult.No)
                                        {
                                                return;
                                        }
                                        db.SaveChanges();
                                        CargarListADeMarcas();
                                } catch (Exception)
                                {
                                        MessageBox.Show("No se pudo actualizar la marca...");
                                }
                        }


                }

                private void materialButton1_Click( object sender, EventArgs e ) {
                        if (idMarca == 0)
                        {
                                MessageBox.Show("No se ha seleccionado ninguna marca...");
                                return;
                        }
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                try
                                {
                                        var Marca = db.Marca_Del_Dispositivo_RP
                                                .FirstOrDefault(x => x.ID_Marca_Dispositivo_RP == idMarca);
                                        var message = MessageBox.Show("Deseas eliminar la marca?", "Eliminar Marca", MessageBoxButtons.YesNo);
                                        if (message == DialogResult.No)
                                        {
                                                return;
                                        }
                                        db.Marca_Del_Dispositivo_RP.Remove(Marca);
                                        db.SaveChanges();
                                        CargarListADeMarcas();
                                } catch (Exception)
                                {
                                        MessageBox.Show("No se pudo eliminar la marca...");
                                }
                        }
                }

                private List<string> HeadersMarcas = new List<string>();
                
                private void materialButton3_Click( object sender, EventArgs e ) {
                        HeadersMarcas.Add("ID");
                        HeadersMarcas.Add("Marca");
                        var MessageRes = MessageBox.Show("Deseas generar el reporte de Marcas?", "Generar Reporte", MessageBoxButtons.YesNo);
                        
                        if (MessageRes == DialogResult.No)
                        {
                                return;
                        }

                        GeneradorDePdf.GeneradorDePDFS(MarcasLST, HeadersMarcas, "Marcas", "PlantillaDeMarcas");
                        MessageBox.Show("Se ha generado el reporte de marcas...");
                }

                private void MyMarcasDG_DataError( object sender, DataGridViewDataErrorEventArgs e ) {

                }
        }
}

