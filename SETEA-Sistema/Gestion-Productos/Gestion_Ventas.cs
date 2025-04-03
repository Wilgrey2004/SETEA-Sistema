using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Entidades;
using SETEA_Sistema.Modelodb;
using SETEA_Sistema.Utilidades.ReturnsBindingList;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema.Gestion_Productos
{
        public partial class Gestion_Ventas : MaterialForm
        {
                BindingList<VentaShowModels> listaVentas = new BindingList<VentaShowModels>();
                GetBindingListVentaModelsShow getList = new GetBindingListVentaModelsShow();
                public Gestion_Ventas() {
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

                private void CargarTabla() {
                        listaVentas = new BindingList<VentaShowModels>(getList.GetBindingList());
                        if (listaVentas != null)
                        {
                                MyDataVentas.DataSource = listaVentas;
                        }
                }
                private void Gestion_Ventas_Load( object sender, EventArgs e ) {
                        CargarTabla();
                }

                private void materialButton1_Click( object sender, EventArgs e ) {
                        CargarTabla();
                }

                private void materialButton2_Click( object sender, EventArgs e ) {
                        CargarTabla();
                }

                int IdDeLaVentaSeleccionada = 0;
                private void MyDataVentas_CellClick( object sender, System.Windows.Forms.DataGridViewCellEventArgs e ) {
                        try
                        {
                                IdDeLaVentaSeleccionada = (int)this.MyDataVentas.Rows[e.RowIndex].Cells[0].Value;
                                MessageBox.Show($"Has Seleccionado el codigo con el ID: {IdDeLaVentaSeleccionada}", "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } catch (Exception err)
                        {
                                MessageBox.Show("Error al obtener el ID: " + err.Message);
                        }
                }

                private void materialButton3_Click( object sender, EventArgs e ) {
                        if (IdDeLaVentaSeleccionada <= 0)
                        {
                                MessageBox.Show("No se ha seleccionado ninguna venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }
                        try
                        {
                                var mensajeAprovar = MessageBox.Show("¿Estas seguro de borrar la venta?", "Aprovar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.VentaEnCaja.FirstOrDefault(sf => sf.id == IdDeLaVentaSeleccionada);
                                        if (query != null)
                                        {
                                                db.VentaEnCaja.Remove(query);
                                                db.SaveChanges();
                                        }

                                }
                        } catch (Exception err)
                        {
                                MessageBox.Show("Error al eliminar la venta: " + err.Message);
                        }
                }

                private void materialButton5_Click( object sender, EventArgs e ) {
                        this.Close();
                }

                private void Fecha_ValueChanged( object sender, EventArgs e ) {
                        GetBindingListVentaModelsShow getListPorLaFecha = new GetBindingListVentaModelsShow();
                        listaVentas.Clear();
                        listaVentas = new BindingList<VentaShowModels>(getListPorLaFecha.GetListConLaFecha(Fecha.Value.Date));
                        MyDataVentas.DataSource = listaVentas;
                }

                private void ProductoNombreFind_TextChanged( object sender, EventArgs e ) {
                        GetBindingListVentaModelsShow getLisPorElNombre = new GetBindingListVentaModelsShow();
                        listaVentas.Clear();
                        listaVentas = new BindingList<VentaShowModels>(getLisPorElNombre.GetListPorNombreOCodigo(ProductoNombreFind.Text));
                        MyDataVentas.DataSource = listaVentas;
                }

                private void materialButton4_Click( object sender, EventArgs e ) {

                }
        }
}
