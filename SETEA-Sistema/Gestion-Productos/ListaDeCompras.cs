using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Modelodb;
using SETEA_Sistema.Modelodb.ModelEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema.Gestion_Productos
{
        public partial class ListaDeCompras : MaterialForm
        {
               
                List<string> cabeceraProductosAgotados1 = new List<string>
                {
                    "ID Producto",
                    "Nombre",
                    "Precio Unitario",
                    "Cantidad"
                };

                List<string> CabeceraDeProductosAComprar = new List<string>
                {
                        "ID",
                        "Nombre",
                        "Precio Unidad",
                        "Cantidad"
                };
                private BindingList<producto> ProductosAgotados = new BindingList<producto>();
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
                        CargarLasColumnasEnDataGridProductosAgotados(MyDataProductosAgotados, ProductosAgotados);
                        CargarLaEstructucturaYLosProductosAComprar(ListaDeComprasVariada,ProductosAComprarlst);



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

                private void CargarLasColumnasEnDataGridProductosAgotados( DataGridView MyProducDg, BindingList<producto> lista ) {
                        MyProducDg.AutoGenerateColumns = false;
                        MyProducDg.Columns.Clear();
                        MyProducDg.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "ID Producto",
                                DataPropertyName = "idProducto",
                                HeaderText = "ID Producto"
                        });

                        MyProducDg.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Nombre",
                                DataPropertyName = "nombre",
                                HeaderText = "Nombre"
                        });

                        MyProducDg.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Precio Unidad",
                                DataPropertyName = "precioUnidad",
                                HeaderText = "Precio Unitario"
                        });

                        MyProducDg.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Cantidad Restante",
                                DataPropertyName = "cantidadRestante",
                                HeaderText = "Cantidad Restante"
                        });

                        MyProducDg.DataSource = lista;
                }
                 private void CargarLaEstructucturaYLosProductosAComprar( DataGridView MyProducDg, BindingList<ProductoAComprar> lista ) {
                        MyProducDg.AutoGenerateColumns = false;
                        MyProducDg.Columns.Clear();
                        MyProducDg.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "ID",
                                DataPropertyName = "ID",
                                HeaderText = "ID "
                        });

                        MyProducDg.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Nombre",
                                DataPropertyName = "nombre",
                                HeaderText = "Nombre"
                        });

                        MyProducDg.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Precio De Unidad",
                                DataPropertyName = "PrecioDeUnidad",
                                HeaderText = "Precio De Unidad"
                        });

                        MyProducDg.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Cantidad A Comprar",
                                DataPropertyName = "CantidadAComprar",
                                HeaderText = "Cantidad A Comprar"
                        });

                        MyProducDg.DataSource = lista;
                }

                private void MueveLosProductosDeUnaListaNormalAUnaBindingListProductos( List<producto> listaNormal, BindingList<producto> listaBinding ) {
                        listaBinding.Clear();
                        foreach (var item in listaNormal)
                        {
                                listaBinding.Add(item);
                                // Inicializa la cantidad en 0 si no existe
                                if (!_cantidadesAComprar.ContainsKey(item.idProducto))
                                {
                                        _cantidadesAComprar.Add(item.idProducto, 0);
                                }
                        }
                }
                private void ObtenerTodosLosProductosAgotados() {
                        using (db = new SeteaEntities1())
                        {
                                var query = db.producto.Where(sw => sw.cantidadRestante == 0).ToList();
                                MueveLosProductosDeUnaListaNormalAUnaBindingListProductos(query, ProductosAgotados);
                        }
                }

                private void ObtenerTodosLosProductosConUnaCantidadMenor( int Cantidad ) {
                        using (db = new SeteaEntities1())
                        {
                                var query = db.producto.Where(sw => sw.cantidadRestante <= Cantidad).ToList();
                                MueveLosProductosDeUnaListaNormalAUnaBindingListProductos(query, ProductosAgotados);
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
                        GenerarPdfApartirDelDatagrid(MyDataProductosAgotados, cabeceraProductosAgotados1);
                }

                private void GenerarPdfApartirDelDatagrid( DataGridView MyProducDg, List<string> listaDeCabeceras ) {
                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.FileName = $"Lista_De_Productos-fecha_y_hora-{DateTime.Now.ToString("dd_MM_yyyy_HH_mm")}.pdf";

                        string cabeceras = $"<tr style=\"background-color: #f5f5f5\"> @AquiVanLasCabeceras </tr>";
                        string headersHechos = "";
                        string filas = "";
                        int totalProductos = 0;


                        foreach (string cabecera in cabeceraProductosAgotados1)
                        {
                                headersHechos += $"<th style=\"padding: 8px; border-bottom: 2px solid #ddd\">{cabecera}</th>";
                        }

                        cabeceras = cabeceras.Replace("@AquiVanLasCabeceras", headersHechos != null ? headersHechos : "No hay Cabeceras");

                        foreach (DataGridViewRow row in MyProducDg.Rows) // Asumiendo que tu DataGridView se llama MyProducDg
                        {
                                if (row.IsNewRow) continue;

                                // Obtener valores de las celdas
                                string idProducto = row.Cells["ID Producto"].Value?.ToString() ?? "";
                                string nombre = row.Cells["Nombre"].Value?.ToString() ?? "";

                                string precioUnidad = row.Cells["Precio Unidad"].Value?.ToString() ?? "0.0";
                                string cantidad = row.Cells["Cantidad Restante"].Value?.ToString() ?? "1";


                                // Calcular valores para el total

                                totalProductos++;

                                // Construir filas HTML
                                filas += "<tr>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd\">{idProducto}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd\">{nombre}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd; text-align: center\">{precioUnidad.ToString()}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd; text-align: center\">{cantidad}</td>";
                                filas += "</tr>";
                        }

                        string paginaHtml_text = Properties.Resources.PlantillaListaDeCompras.ToString();

                        // Reemplazar placeholders
                        paginaHtml_text = paginaHtml_text
                            .Replace("@Cabecera", cabeceras)
                            .Replace("@Filas", filas);



                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                                {
                                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                                        pdfDoc.Open();

                                        // Agregar imagen (ajusta según tu necesidad)
                                        iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(Properties.Resources.image, System.Drawing.Imaging.ImageFormat.Png);
                                        image.ScaleToFit(80, 60);
                                        image.Alignment = iTextSharp.text.Image.UNDERLYING;
                                        image.SetAbsolutePosition(25, pdfDoc.PageSize.Height - 80);
                                        pdfDoc.Add(image);

                                        using (StringReader reader = new StringReader(paginaHtml_text))
                                        {
                                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, reader);
                                        }

                                        pdfDoc.Close();
                                }
                        }
                }


                private void GenerarPdfApartirDelDatagridListaDeProductos( DataGridView MyProducDg, List<string> listaDeCabeceras ) {
                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.FileName = $"Lista_De_Productos-fecha_y_hora-{DateTime.Now.ToString("dd_MM_yyyy_HH_mm")}.pdf";

                        string cabeceras = $"<tr style=\"background-color: #f5f5f5\"> @AquiVanLasCabeceras </tr>";
                        string headersHechos = "";
                        string filas = "";
                        int totalProductos = 0;


                        foreach (string cabecera in cabeceraProductosAgotados1)
                        {
                                headersHechos += $"<th style=\"padding: 8px; border-bottom: 2px solid #ddd\">{cabecera}</th>";
                        }

                        cabeceras = cabeceras.Replace("@AquiVanLasCabeceras", headersHechos != null ? headersHechos : "No hay Cabeceras");

                        foreach (DataGridViewRow row in MyProducDg.Rows) // Asumiendo que tu DataGridView se llama MyProducDg
                        {
                                if (row.IsNewRow) continue;

                                // Obtener valores de las celdas
                                string idProducto = row.Cells["ID"].Value?.ToString() ?? "";
                                string nombre = row.Cells["Nombre"].Value?.ToString() ?? "";

                                string precioUnidad = row.Cells["Precio De Unidad"].Value?.ToString() ?? "0.0";
                                string cantidad = row.Cells["Cantidad A Comprar"].Value?.ToString() ?? "1";


                                // Calcular valores para el total

                                totalProductos++;

                                // Construir filas HTML
                                filas += "<tr>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd\">{idProducto}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd\">{nombre}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd; text-align: center\">{precioUnidad.ToString()}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd; text-align: center\">{cantidad}</td>";
                                filas += "</tr>";
                        }

                        string paginaHtml_text = Properties.Resources.PlantillaListaDeCompras.ToString();

                        // Reemplazar placeholders
                        paginaHtml_text = paginaHtml_text
                            .Replace("@Cabecera", cabeceras)
                            .Replace("@Filas", filas);



                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                                {
                                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                                        pdfDoc.Open();

                                        // Agregar imagen (ajusta según tu necesidad)
                                        iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(Properties.Resources.image, System.Drawing.Imaging.ImageFormat.Png);
                                        image.ScaleToFit(80, 60);
                                        image.Alignment = iTextSharp.text.Image.UNDERLYING;
                                        image.SetAbsolutePosition(25, pdfDoc.PageSize.Height - 80);
                                        pdfDoc.Add(image);

                                        using (StringReader reader = new StringReader(paginaHtml_text))
                                        {
                                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, reader);
                                        }

                                        pdfDoc.Close();
                                }
                        }
                }


                private void MyDataProductosAgotados_CellContentClick( object sender, DataGridViewCellEventArgs e ) {

                }


                private void MyDataProductosAgotados_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        if (e.RowIndex >= 0)
                        {
                                id = (int)MyDataProductosAgotados.Rows[e.RowIndex].Cells["ID Producto"].Value;
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

                                if (resultado == DialogResult.Yes)
                                {
                                        // Modificado: Buscar en la lista existente en lugar de la base de datos
                                        producto productoAEliminar = ProductosAgotados.FirstOrDefault(p => p.idProducto == id);

                                        if (productoAEliminar != null)
                                        {
                                                ProductosAgotados.Remove(productoAEliminar);
                                                ActualizarLista();
                                        } else
                                        {
                                                MessageBox.Show("El producto no existe en la lista",
                                                            "Error",
                                                            MessageBoxButtons.OK,
                                                            MessageBoxIcon.Warning);
                                        }
                                }
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

                private void AgregarProductoAUnaListaBiln( string proName, BindingList<producto> list ) {
                        using (db = new SeteaEntities1())
                        {
                                var query = db.producto.FirstOrDefault(sf => sf.nombre == proName);
                                if (query != null)
                                {
                                        list.Add(query);
                                }
                        }
                }
                private void materialButton5_Click( object sender, EventArgs e ) {
                        AgregarProductoAUnaListaBiln(ProductoName.Text, ProductosAgotados);
                }



                private void MyDataProductosAgotados_CellFormatting( object sender, DataGridViewCellFormattingEventArgs e ) {
                        if (MyDataProductosAgotados.Columns[e.ColumnIndex].Name == "Cantidad A Comprar" && e.RowIndex >= 0)
                        {
                                var row = MyDataProductosAgotados.Rows[e.RowIndex];

                                if (!row.IsNewRow)
                                {
                                        var cell = row.Cells["ID Producto"];

                                        if (cell != null)
                                        {
                                                var cellValue = cell.Value;

                                                if (cellValue != null)
                                                {
                                                        int rowId = (int)cellValue;

                                                        if (_cantidadesAComprar.TryGetValue(rowId, out int cantidad))
                                                        {
                                                                e.Value = cantidad;
                                                                e.FormattingApplied = true;
                                                        }
                                                } else
                                                {
                                                        MessageBox.Show("El valor de la celda 'ID Producto' es nulo.");
                                                }
                                        } else
                                        {
                                                MessageBox.Show("La celda 'ID Producto' no existe.");
                                        }
                                }
                        }
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
                                MessageBox.Show("Tienes que rellenar toda la informacion solicitada antes de clicar en aceptar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                return;
                        }

                        ProductoAComprar proNewAComprar = new ProductoAComprar();

                        proNewAComprar.Nombre = NameNewProducto.Text;

                        proNewAComprar.CantidadAComprar = CantidadNewProduct.Value;

                        if(decimal.TryParse(PrecioNewProducto.Text, out decimal cantidad))
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
                                if(query != null)
                                {
                                        ProductosAComprarlst.Remove(query);
                                        CargarLaEstructucturaYLosProductosAComprar(ListaDeComprasVariada, ProductosAComprarlst);
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
                        GenerarPdfApartirDelDatagridListaDeProductos(ListaDeComprasVariada, CabeceraDeProductosAComprar);
                }
        }
}
