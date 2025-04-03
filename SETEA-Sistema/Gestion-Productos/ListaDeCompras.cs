using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Entidades;
using SETEA_Sistema.Modelodb;
using SETEA_Sistema.Modelodb.ModelEntity;
using SETEA_Sistema.Utilidades;
using SETEA_Sistema.Utilidades.ReturnsBindingList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema.Gestion_Productos
{
        public partial class ListaDeCompras : MaterialForm
        {

                private BindingList<ProductoReporteModelShows> ProductosAgotados = new BindingList<ProductoReporteModelShows>();
                private BindingList<ProductoAComprar> ProductosAComprarlst = new BindingList<ProductoAComprar>();
                private SeteaEntities1 db;

                private int id = 0;
                private Dictionary<int, int> _cantidadesAComprar = new Dictionary<int, int>();

                public ListaDeCompras() {
                        InitializeComponent();

                        MyDataProductosAgotados.CellFormatting += MyDataProductosAgotados_CellFormatting;
                        MyDataProductosAgotados.CellValueChanged += MyDataProductosAgotados_CellValueChanged;

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
                        ListaDeComprasVariada.DataSource = ProductosAComprarlst;
                }

                private void ListaDeCompras_Load( object sender, EventArgs e ) {
                        ObtenerTodosLosProductosAgotados();
                        CargarComboBoxDeProductos();
                        CargarLaCantidadRestanteEnElComboboxSegunElProducto();
                }

                // Clase modelo corregida


                // Método corregido
                private void CargarComboBoxDeProductos() {
                        try
                        {
                                using (db = new SeteaEntities1())
                                {
                                        var productos = db.producto
                                            .Select(p => new productoComboBoxModel {
                                                    Id = p.idProducto,
                                                    Nombre = p.nombre
                                            })
                                            .ToList();

                                        List<string> lst = new List<string>();
                                        foreach (var product in productos)
                                        {
                                                lst.Add(product.Nombre.ToString());
                                        }

                                        ProductoName.DataSource = lst;

                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show($"Error al cargar productos: {ex.Message}");
                        }
                }



                private void ObtenerTodosLosProductosAgotados() {
                        try
                        {
                                GetBindingListProductoShowsModels getBProductos = new GetBindingListProductoShowsModels();
                                var query = getBProductos.GetBindingListProductosPorCantidad(0);
                                if (query == null)
                                {
                                        MessageBox.Show("No se encontraron productos agotados");
                                        return;
                                }

                                ProductosAgotados.Clear();

                                foreach (var producto in query)
                                {
                                        ProductosAgotados.Add(producto);
                                }

                                MyDataProductosAgotados.DataSource = ProductosAgotados;

                        } catch (Exception ex)
                        {
                                MessageBox.Show($"Error al cargar productos agotados: {ex.Message}");
                                Close();
                                return;
                        }

                }

                private void ObtenerTodosLosProductosConUnaCantidadMenor( int Cantidad ) {
                        ProductosAgotados.Clear();

                        GetBindingListProductoShowsModels getBProductos = new GetBindingListProductoShowsModels();
                        var query = getBProductos.GetBindingListProductosPorCantidad(Cantidad);

                        foreach (var producto in query)
                        {
                                ProductosAgotados.Add(producto);
                        }
                }

                private void materialButton2_Click( object sender, EventArgs e ) {
                        ObtenerTodosLosProductosAgotados();
                }

                private bool LaCantidadEsMayorACero( int cantidad ) {
                        if (cantidad > 0)
                        {
                                return true;
                        }

                        return false;
                }

                private void materialButton3_Click( object sender, EventArgs e ) {

                        int cantidadPase = Convert.ToInt32(Cantidad.Value);
                        if (LaCantidadEsMayorACero(cantidadPase))
                        {
                                ObtenerTodosLosProductosConUnaCantidadMenor(cantidadPase);
                                return;
                        } else
                        {
                                MessageBox.Show("La cantidad No puede ser Igual a 0 \n ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                CambiarColorARojo(Cantidad);
                        }

                }

                private void CambiarColorARojo( NumericUpDown caja ) {
                        caja.BackColor = Color.LightPink;
                }

                private void CambiaColorABlanco( NumericUpDown caja ) {
                        caja.BackColor = Color.White;
                }
                private void Cantidad_ValueChanged( object sender, EventArgs e ) {
                        CambiaColorABlanco(Cantidad);
                }

                private void materialButton1_Click( object sender, EventArgs e ) {
                        GenerarPdfApartirDelDatagrid();
                }
                private List<string> HeadersProductos = new List<string> { "ID", "Nombre", "Descripcion", "Cantidad", "Precio", "Categoria", "Estado", "Fecha" };

                private void GenerarPdfApartirDelDatagrid() {
                        var MensajeResponder = MessageBox.Show("¿Quieres generar el PDF de la lista de productos agotados?", "Generar PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (MensajeResponder == DialogResult.No)
                        {
                                return;
                        }
                        GetBindingListProductoShowsModels getBProductos = new GetBindingListProductoShowsModels();
                        GeneradorDePdf.GeneradorDePDFS(ProductosAgotados, HeadersProductos, "ListaDeProductos", "PlantillaReportProductosAgotados");
                        MessageBox.Show("Se ha generado el PDF", "PDF Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                List<string> HeadersProductosAComprar = new List<string> { "ID", "Nombre", "Cantidad A Comprar", "Precio de Unidad" };
                private void GenerarPdfApartirDelDatagridListaDeProductos() {
                        var MensajeResponder = MessageBox.Show("¿Quieres generar el PDF de la lista?", "Generar PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (MensajeResponder == DialogResult.No)
                        {
                                return;
                        }
                        GeneradorDePdf.GeneradorDePDFS(ProductosAComprarlst, HeadersProductosAComprar, "LustaDeComprasVarias", "PlantillaReportProductosAgotados");
                        MessageBox.Show("Se ha generado el PDF", "PDF Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                private void MyDataProductosAgotados_CellContentClick( object sender, DataGridViewCellEventArgs e ) {

                }


                private void MyDataProductosAgotados_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        if (e.RowIndex >= 0)
                        {
                                id = (int)MyDataProductosAgotados.Rows[e.RowIndex].Cells[0].Value;
                                MessageBox.Show($"Has Seleccionado el producto con el ID: {id}", "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
                private bool ElIdEsMayorACero( int idCuestion ) {
                        if (idCuestion == 0)
                        {
                                return false;
                        }

                        return true;
                }
                private void ActualizarLista() {
                        MyDataProductosAgotados.DataSource = ProductosAgotados;
                }
                private void materialButton4_Click( object sender, EventArgs e ) {
                        if (ElIdEsMayorACero(id))
                        {
                                DialogResult resultado = MessageBox.Show("¿Estás seguro de borrar el producto?",
                                                                    "Borrar",
                                                                    MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Error);

                                if (resultado == DialogResult.No)
                                {
                                        MessageBox.Show("No se ha borrado el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                }

                                ProductosAgotados.Remove(ProductosAgotados.FirstOrDefault(sf => sf.ID_Producto == id));
                                MessageBox.Show("Se ha borrado el producto", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else
                        {
                                MessageBox.Show("Selecciona un producto primero",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        }
                }

                private void tabPage1_Click( object sender, EventArgs e ) {

                }

                private bool ComboboxEsNulo( ComboBox cm ) {

                        if (cm.Text.Equals(null))
                        {
                                return false;
                        }
                        return true;
                }

                private void CargarLaCantidadRestanteEnElComboboxSegunElProducto() {
                        using (db = new SeteaEntities1())
                        {
                                if (ComboboxEsNulo(ProductoName))
                                {
                                        var query = db.producto.FirstOrDefault(sf => sf.nombre == ProductoName.Text);

                                        if (query != null)
                                        {
                                                txtCantidadRestante.Text = query.cantidadRestante.ToString();
                                        }
                                }

                        }
                }

                private void ProductoName_SelectedIndexChanged( object sender, EventArgs e ) {
                        CargarLaCantidadRestanteEnElComboboxSegunElProducto();
                }


                private void materialButton5_Click( object sender, EventArgs e ) {

                }



                private void MyDataProductosAgotados_CellFormatting( object sender, DataGridViewCellFormattingEventArgs e ) {

                }




                private void MyDataProductosAgotados_CellValueChanged( object sender, DataGridViewCellEventArgs e ) {
                        if (e.ColumnIndex == MyDataProductosAgotados.Columns["Cantidad A Comprar"].Index && e.RowIndex >= 0)
                        {
                                id = (int)MyDataProductosAgotados.Rows[e.RowIndex].Cells["ID Producto"].Value;
                                var cell = MyDataProductosAgotados.Rows[e.RowIndex].Cells["Cantidad A Comprar"];

                                if (cell.Value != null && int.TryParse(cell.Value.ToString(), out int cantidad))
                                {
                                        _cantidadesAComprar[id] = cantidad;
                                }
                        }
                }

                private void MyDataProductosAgotados_DataError( object sender, DataGridViewDataErrorEventArgs e ) {
                        //No hace na pero he pa ayanta al programa
                }

                private bool TodasLosDatosEstanLlenos() {
                        return NameNewProducto.Text != null && CantidadNewProduct.Value > 0 && PrecioNewProducto.Text != null;
                }
                private void materialButton6_Click( object sender, EventArgs e ) {
                        if (!TodasLosDatosEstanLlenos())
                        {
                                MessageBox.Show("Tienes que rellenar toda la informacion solicitada antes de clicar en aceptar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        ProductoAComprar proNewAComprar = new ProductoAComprar();

                        proNewAComprar.Nombre = NameNewProducto.Text;

                        proNewAComprar.CantidadAComprar = CantidadNewProduct.Value;

                        if (decimal.TryParse(PrecioNewProducto.Text, out decimal cantidad))
                        {
                                proNewAComprar.PrecioDeUnidad = cantidad;
                        } else
                        {
                                MessageBox.Show("En esta parte van numeros no letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }


                        ProductosAComprarlst.Add(proNewAComprar);
                }
                private void LimpiarTodasLasCajas() {
                        NameNewProducto.Text = "";
                        PrecioNewProducto.Text = "";
                        CantidadNewProduct.Value = 0;
                }
                private void materialButton8_Click( object sender, EventArgs e ) {

                        LimpiarTodasLasCajas();
                        return;

                }

                private void materialButton9_Click( object sender, EventArgs e ) {
                        ProductosAComprarlst.Clear();
                }

                private void materialButton7_Click( object sender, EventArgs e ) {
                        if (ElIdEsMayorACero(id2))
                        {
                                var query = ProductosAComprarlst.FirstOrDefault(sf => sf.id == id2);
                                if (query != null)
                                {
                                        ProductosAComprarlst.Remove(query);

                                } else
                                {
                                        MessageBox.Show($"No se logro Eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                        return;
                                }
                        } else
                        {
                                MessageBox.Show($"No has Seleccionado un producto de la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                }
                int id2 = 0;
                private void ListaDeComprasVariada_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        if (e.RowIndex >= 0)
                        {
                                id2 = (int)ListaDeComprasVariada.Rows[e.RowIndex].Cells["ID"].Value;
                                MessageBox.Show($"Has Seleccionado el producto con el ID: {id2}", "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }

                private void materialButton10_Click( object sender, EventArgs e ) {
                        GenerarPdfApartirDelDatagridListaDeProductos();
                }
        }
}
