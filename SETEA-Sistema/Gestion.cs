using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Entidades;
using SETEA_Sistema.Gestion_Productos;
using SETEA_Sistema.Modelodb;
using SETEA_Sistema.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace SETEA_Sistema
{
        public partial class Gestion : MaterialForm
        {

                private SeteaEntities1 db;
                private List<Usuarios> usl = new List<Usuarios>();
                private string NumeroTelefonicoCliente = "";
                List<string> headersUsers = new List<string> { "ID", "Nombre", "Apellido", "Telefono", "Correo", "Fecha Creacion", "Rol" };
                private BindingList<VentaEnCaja> ventaEnCajaLista = new BindingList<VentaEnCaja>();
                private BindingList<producto> productosLs = new BindingList<producto>();
                private int idProductoSeleccionado = 0;
                private int idProductoSeleccionadoEdicion = 0;
                private string NombreProductoSeleccionado = "";
                public Gestion() {
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


                        numCantidadProducto.Minimum = 0;

                        ModificarDataGridVentas();
                        ModificarDataGridProductos();

                }
                private void ModificarDataGridProductos() {
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
                                Name = "Descripcion",
                                DataPropertyName = "descripcion",
                                HeaderText = "Descripción"
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

                        MyProducDg.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Categoria ID",
                                DataPropertyName = "categoriaId",
                                HeaderText = "Categoría ID"
                        });

                        MyProducDg.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Fecha Creacion",
                                DataPropertyName = "fechaCreacion",
                                HeaderText = "Fecha Creación"
                        });


                        MyProducDg.DataSource = productosLs;
                        CargarTodosLosProductosDesdeLaDb();
                }
                private void ModificarDataGridVentas() {

                        MyDataProductosCaja.AutoGenerateColumns = false;
                        MyDataProductosCaja.Columns.Clear();

                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Nombre Cliente",
                                DataPropertyName = "Nombre",   // Propiedad de tu objeto VentaEnCaja
                                HeaderText = "Nombre Cliente"
                        });
                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Telefono",
                                DataPropertyName = "NumeroDelCliente",
                                HeaderText = "Telefono"
                        });
                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Nombre Del Producto",
                                DataPropertyName = "ProductoNombre", // Corregir el typo aquí
                                HeaderText = "Nombre Del Producto"
                        });

                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "codigo Del Producto",
                                DataPropertyName = "codigoDelProducto", // Corregir el typo aquí
                                HeaderText = "codigo Del Producto"
                        });

                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "id Prodicto",
                                DataPropertyName = "idProdicto", // Asegúrate de que coincide con la propiedad de tu objeto
                                HeaderText = "id Prodicto"
                        });
                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "cantidad Producto",
                                DataPropertyName = "cantidadProducto",
                                HeaderText = "cantidad Producto"
                        });
                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Precio Unidad",
                                DataPropertyName = "PrecioUnidad",
                                HeaderText = "Precio Unidad"
                        });
                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "precio Por Cantidad",
                                DataPropertyName = "precioPorCantidad",
                                HeaderText = "precio Por Cantidad"
                        });
                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Descuento",
                                DataPropertyName = "Descuento",  // Debes tener esta propiedad en tu clase VentaEnCaja
                                HeaderText = "Descuento"
                        });
                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Fecha Venta",
                                DataPropertyName = "FechaVenta",  // Debes tener esta propiedad en tu clase VentaEnCaja
                                HeaderText = "Fecha Venta"
                        });


                        MyDataProductosCaja.DataSource = ventaEnCajaLista;
                }
                private void ActualizarTablaUser() {


                        using (db = new SeteaEntities1())
                        {
                                usl = db.Usuarios.ToList();

                                if (usl.Count > 0 && usl != null)
                                {
                                        MyDataUsers.DataSource = usl;
                                }
                        }

                        MyDataUsers.Columns["Roles"].Visible = false;
                }
                private void GenerarReporteUsuarios() {
                        GeneradorDePdf generador = new GeneradorDePdf();
                        using (db = new SeteaEntities1())
                        {
                                var query = db.Usuarios.ToList();
                                BindingList<Usuarios> usl = new BindingList<Usuarios>(query);

                                string rutaPlantilla = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "PlantillaReporteUsuarios.html");
                                string rutaSalida = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes/Usuarios", $"Reporte-{DateTime.Now:yyyyMMddHHmmss}.pdf");

                                generador.GenerarPdf(usl, headersUsers, rutaPlantilla, rutaSalida);
                        }
                }

                private void CargarTablaConRegistrosDiario() {
                        using (db = new SeteaEntities1())
                        {
                                var fechaHoy = DateTime.Today;
                                usl = db.Usuarios
                                        .Where(wh => wh.FechaCreacion.Value == fechaHoy)
                                        .ToList();

                                if (usl != null && usl.Count > 0)
                                {
                                        MyDataUsers.DataSource = usl;
                                        GenerarReporteUsuarios();
                                } else
                                {
                                        MessageBox.Show("Aún no se ha creado un usuario hoy.");
                                }
                        }
                        MyDataUsers.Columns["Auditoria"].Visible = false;
                        MyDataUsers.Columns["Roles"].Visible = false;
                }

                private void CargarTablaProductos() {

                }
                private void CargarTablas() {
                        ActualizarTablaUser();
                        CargarTablaDeCodigos();
                }

                private BindingList<CodigosDeproductosShowsModels> codigosDeProductosList = new BindingList<CodigosDeproductosShowsModels>();

                private void CargarTablaDeCodigos() {
                        codigosDeProductosList.Clear();
                        using (db = new SeteaEntities1())
                        {
                                var query = db.Codigo_De_Productos.Include(x => x.producto)
                                    .Select(x => new CodigosDeproductosShowsModels {
                                            ID_Del_Codigo = x.ID,
                                            ID_Producto = x.ID_Producto_Enlazado,
                                            Nombre_Del_Producto = x.producto.nombre,
                                            Codigo_Del_Producto = x.CodigoDelProducto,
                                            Cantidad_Restante = x.producto.cantidadRestante,
                                            Precio_Del_Producto = x.producto.PrecioUnidad,
                                            Fecha_De_Creacion = (DateTime)x.Fecha_De_Agregacion

                                    }).ToList();

                                if (query == null)
                                {
                                        MessageBox.Show("Aun no hay codigos de productos agregados...", "Codigos de producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                }

                                foreach (var item in query)
                                {
                                        codigosDeProductosList.Add(item);
                                }

                                ListaDecodigosProductos.DataSource = codigosDeProductosList;
                        }
                }

                private void CargarProductos( string codigo ) {


                        using (db = new SeteaEntities1())
                        {
                                var query = db.Codigo_De_Productos.Include(c => c.producto).Select(x => new {
                                        x.CodigoDelProducto,
                                        ProductoNombre = x.producto.nombre
                                }).ToList();




                                if (codigo == null)
                                {
                                        MessageBox.Show("No hay ningun codigo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        return;
                                }

                                var filtro = query.FirstOrDefault(x => x.CodigoDelProducto == codigo);

                                if (filtro == null)
                                {
                                        MessageBox.Show("No se encontró ningún producto con el código proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                }

                                MyProductos.Text = filtro.ProductoNombre;


                        }




                }
                //private void CargarProductos()
                //{
                //    List<string> productosList = new List<string>();

                //    using (db = new SeteaEntities1())
                //    {
                //        var query = db.producto.Where(sf => sf.cantidadRestante > 0).ToList();
                //        // Selecciona solo los nombres de los productos y conviértelos en una lista de strings
                //        productosList = query
                //                        .Select(p => p.nombre) // Selecciona solo el nombre
                //                        .ToList(); // Convierte el resultado en una lista de strings

                //        if (productosList != null)
                //        {
                //            MyProductos.DataSource = productosList;
                //        }
                //        else
                //        {
                //            MessageBox.Show("Los productos no han cargado");
                //        }
                //    }
                //}
                private void Gestion_Load( object sender, EventArgs e ) {
                        CargarTablas();
                        ConfiguracionDelDataGrid(MyDataProductosCaja);
                        ConfiguracionDelDataGrid(ListaDecodigosProductos, 70);
                        numCantidadProducto.Minimum = 1;
                        // CargarProductos();
                }

                private void ConfiguracionDelDataGrid( DataGridView MyDataProductosCaja ) {
                        MyDataProductosCaja.ColumnHeadersVisible = true;
                        MyDataProductosCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        MyDataProductosCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                        MyDataProductosCaja.ColumnHeadersHeight = 45;
                }
                private void ConfiguracionDelDataGrid( DataGridView MyDataProductosCaja, int Cabeceras ) {
                        MyDataProductosCaja.ColumnHeadersVisible = true;
                        MyDataProductosCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        MyDataProductosCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                        MyDataProductosCaja.ColumnHeadersHeight = Cabeceras;
                }
                private void GestionUsuarios_Click( object sender, EventArgs e ) {

                }

                private void MyDataUsers_DataError( object sender, DataGridViewDataErrorEventArgs e ) {

                }

                private void MyDataUsers_CellContentClick( object sender, DataGridViewCellEventArgs e ) {

                }

                private void Gestion_DoubleClick( object sender, EventArgs e ) {

                }

                private void MyDataUsers_CellContentDoubleClick( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {
                                int id = (int)this.MyDataUsers.SelectedRows[0].Cells[0].Value;
                                UsuariosAcciones userAccions = new UsuariosAcciones();
                                Hide();
                                userAccions.id = id;
                                userAccions.ShowDialog();
                                Show();
                                ActualizarTablaUser();
                        } catch (Exception)
                        {
                                return;
                        }
                }

                private void materialButton1_Click( object sender, EventArgs e ) {
                        ActualizarTablaUser();
                        GenerarReporteUsuarios();
                }

                private void materialButton2_Click( object sender, EventArgs e ) {
                        CargarTablaConRegistrosDiario();
                        ActualizarTablaUser();
                }


                private void materialComboBox1_SelectedIndexChanged( object sender, EventArgs e ) {
                        string productoNombre = MyProductos.Text;

                        using (db = new SeteaEntities1())
                        {
                                producto proPrecio = new producto();
                                proPrecio = db.producto.FirstOrDefault(p => p.nombre == productoNombre);
                                myProductoPrecio.Text = proPrecio.PrecioUnidad.ToString();
                                numCantidadProducto.Maximum = (decimal)proPrecio.cantidadRestante;
                                numCantidadProducto.Value = proPrecio.cantidadRestante == 0 ? 0 : 1;
                                idProductoSeleccionado = proPrecio.idProducto;
                                txtPrecioTotalPorCantidad.Text = proPrecio.PrecioUnidad.ToString();
                                NombreProductoSeleccionado = proPrecio.nombre;
                        }
                }

                private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e ) {

                }

                private void numCantidadProducto_ValueChanged( object sender, EventArgs e ) {
                        double precioUnidad = Convert.ToDouble(myProductoPrecio.Text);
                        int cantidadProducto = Convert.ToInt32(numCantidadProducto.Value);

                        if (precioUnidad > 0 && cantidadProducto > 0)
                        {
                                double resultado = cantidadProducto * precioUnidad;
                                txtPrecioTotalPorCantidad.Text = resultado.ToString();
                        }
                }

                private void CalCularTotalVenta() {
                        double? total = 0;
                        foreach (VentaEnCaja item in ventaEnCajaLista)
                        {
                                if ((double?)item.precioPorCantidad != null)
                                {
                                        total += (double?)item.precioPorCantidad;
                                }
                        }
                        MyTotalVentaProductos.Text = total.ToString();
                }


                private void materialButton6_Click( object sender, EventArgs e ) {

                        int descuento_ = MyConversorGenerico.DeStringANumero<int>(ProductoVentaDescuento.Text) <= 0 ? 1 : MyConversorGenerico.DeStringANumero<int>(ProductoVentaDescuento.Text);
                        decimal precioUnidad_ = MyConversorGenerico.DeStringANumero<decimal>(myProductoPrecio.Text);
                        decimal precioPorCantidad_ = MyConversorGenerico.DeStringANumero<decimal>(txtPrecioTotalPorCantidad.Text);
                        int cantidadProducto_ = Convert.ToInt32(numCantidadProducto.Value);

                        NumeroTelefonicoCliente = TelefonoCompraCaja.Text;
                        // Crear un nuevo objeto VentaEnCaja con los datos del formulario
                        VentaEnCaja nuevaVenta = new VentaEnCaja {
                                idProdicto = idProductoSeleccionado != 0 ? idProductoSeleccionado : 1,
                                codigoDelProducto = CodigoDelProductoVenta.Text,
                                Nombre = txtNombreCliente.Text == string.Empty ? "No nombre del Cliente" : txtNombreCliente.Text,
                                ProductoNombre = NombreProductoSeleccionado,
                                NumeroDelCliente = NumeroTelefonicoCliente == string.Empty ? "No numero del cliente" : NumeroTelefonicoCliente,
                                cantidadProducto = cantidadProducto_,
                                PrecioUnidad = descuento_ == 0 ? precioUnidad_ : (precioUnidad_ * (descuento_ / 100)),
                                Descuento = descuento_ == 0 ? 1 : descuento_,
                                precioPorCantidad = precioPorCantidad_
                        };
                        // Agregar el nuevo objeto a la lista
                        ventaEnCajaLista.Add(nuevaVenta);


                        // No es necesario actualizar el DataSource manualmente
                        CalCularTotalVenta();
                }

                private void txtNombreCliente_Click( object sender, EventArgs e ) {

                }

                private void materialButton4_Click( object sender, EventArgs e ) {
                        ventaEnCajaLista.Clear();
                        CalCularTotalVenta();

                }
                int filaRemoverProductos = 0;
                private void MyDataProductosCaja_CellClick( object sender, DataGridViewCellEventArgs e ) {

                        if (e.RowIndex >= 0 && e.RowIndex < ventaEnCajaLista.Count)
                        {

                                filaRemoverProductos = e.RowIndex;
                                CalCularTotalVenta();
                        }
                }

                private void materialButton5_Click( object sender, EventArgs e ) {
                        if (ventaEnCajaLista != null)
                        {
                                ventaEnCajaLista.RemoveAt(filaRemoverProductos);
                        }
                        return;
                }

                private void GenerarFacturaVentas() {
                        string nameCliente = txtNombreCliente.Text != null ? txtNombreCliente.Text : "ClienteVacio";
                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.FileName = $"Venta al cliente ${nameCliente} de la fecha y hora ${DateTime.Now.ToString("ddmmyyyHHmm")}.pdf";
                        saveFile.ShowDialog();
                        string filas = "";
                        foreach (DataGridViewRow row in MyDataProductosCaja.Rows)
                        {
                                if (row.IsNewRow)
                                        continue; // Omite la fila en blanco que permite agregar nuevos registros.
                                string nombreCliente = row.Cells["Nombre Cliente"].Value?.ToString() ?? "";
                                string nombreProducto = row.Cells["Nombre Del Producto"].Value?.ToString() ?? "";
                                string numeroTelefono = row.Cells["Telefono"].Value?.ToString();
                                string idProdicto = row.Cells["id Prodicto"].Value?.ToString() ?? "";
                                string cantidadProducto = row.Cells["cantidad Producto"].Value?.ToString() ?? "";
                                string precioUnidad = row.Cells["Precio Unidad"].Value?.ToString() ?? "";
                                string Descuento = row.Cells["Descuento"].Value?.ToString() ?? "";
                                string precioPorCantidad = row.Cells["precio Por Cantidad"].Value?.ToString() ?? "";
                                string fechaVenta = row.Cells["Fecha Venta"].Value?.ToString() ?? "";
                                filas += "<tr>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; width: 20%\"> {nombreCliente} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; width: 20%\"> {numeroTelefono} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; width: 20%\"> {nombreProducto} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; width: 20%\"> {idProdicto} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; width: 20%\"> {cantidadProducto} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; width: 20%\"> {precioUnidad} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; width: 20%\"> {Descuento} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; width: 20%\"> {precioPorCantidad} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; width: 20%\"> {fechaVenta} </td>";
                                filas += "</tr>";
                        }
                        double total = Convert.ToDouble(MyTotalVentaProductos.Text);
                        string paginaHtml_text = Properties.Resources.PlantillaFactura.ToString();
                        // Error en el formato (usa "-" en lugar de "/")
                        paginaHtml_text = paginaHtml_text.Replace("@Fecha", DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
                        paginaHtml_text = paginaHtml_text.Replace("@Filas", filas);
                        paginaHtml_text = paginaHtml_text.Replace("@Total", $"<span>{total.ToString("N2")}</span>");
                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                                {
                                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                        pdfDoc.Open();
                                        pdfDoc.Add(new Phrase(""));
                                        iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(Properties.Resources.image, System.Drawing.Imaging.ImageFormat.Png);
                                        image.ScaleToFit(80, 90);
                                        image.Alignment = iTextSharp.text.Image.UNDERLYING;
                                        image.SetAbsolutePosition(25, 780);
                                        pdfDoc.Add(image);
                                        using (StringReader reader = new StringReader(paginaHtml_text))
                                        {
                                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, reader);
                                        }
                                        pdfDoc.Close();
                                        stream.Close();
                                }
                        }
                }

                private bool EstaCajaEstaVacia( MaterialTextBox2 textBox ) {
                        return textBox.Text != "";
                }
                public void GenerarFacturaP80( DataGridView dgv ) {
                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.FileName = $"FacturaP80_{DateTime.Now:ddMMyyyyHHmm}.pdf";
                        saveFile.Filter = "Archivos PDF|*.pdf";
                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                                // Definir tamaño p80: 80mm de ancho ≈ 226.77 puntos; altura fija ajustable según contenido
                                Rectangle pageSize = new Rectangle(226.77f, 600f);
                                Document pdfDoc = new Document(pageSize, 10, 10, 10, 10);
                                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                                {
                                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                        pdfDoc.Open();
                                        // Encabezado con fuente más pequeña
                                        pdfDoc.Add(new Paragraph("Factura P80", FontFactory.GetFont("Arial", "", Font.Bold)));
                                        pdfDoc.Add(new Paragraph($"Fecha: {DateTime.Now:dd-MM-yyyy HH:mm}", FontFactory.GetFont("Arial", 7)));
                                        pdfDoc.Add(new Paragraph(" ", FontFactory.GetFont("Arial", 6)));

                                        // Crear tabla de 8 columnas
                                        PdfPTable tabla = new PdfPTable(8);
                                        tabla.WidthPercentage = 100;
                                        string[] cabeceras = { "Nom", "Tel", "Produc", "ID", "Cant", "P.U.", "P.Total", "Fecha" };
                                        foreach (string cab in cabeceras)
                                        {
                                                PdfPCell celda = new PdfPCell(new Phrase(cab, FontFactory.GetFont("Arial", "", Font.Bold))) {
                                                        HorizontalAlignment = Element.ALIGN_CENTER
                                                };
                                                tabla.AddCell(celda);
                                        }
                                        // Rellenar la tabla con las filas del DataGridView
                                        foreach (DataGridViewRow row in dgv.Rows)
                                        {
                                                if (row.IsNewRow) continue;
                                                tabla.AddCell(new PdfPCell(new Phrase(row.Cells["Nombre Cliente"].Value?.ToString() ?? "", FontFactory.GetFont("Arial", 6))));
                                                tabla.AddCell(new PdfPCell(new Phrase(row.Cells["Telefono"].Value?.ToString() ?? "", FontFactory.GetFont("Arial", 6))));
                                                tabla.AddCell(new PdfPCell(new Phrase(row.Cells["Nombre Del Producto"].Value?.ToString() ?? "", FontFactory.GetFont("Arial", 4))));
                                                tabla.AddCell(new PdfPCell(new Phrase(row.Cells["id Prodicto"].Value?.ToString() ?? "", FontFactory.GetFont("Arial", 6))));
                                                tabla.AddCell(new PdfPCell(new Phrase(row.Cells["cantidad Producto"].Value?.ToString() ?? "", FontFactory.GetFont("Arial", 6))));
                                                tabla.AddCell(new PdfPCell(new Phrase(row.Cells["Precio Unidad"].Value?.ToString() ?? "", FontFactory.GetFont("Arial", 6))));
                                                tabla.AddCell(new PdfPCell(new Phrase(row.Cells["precio Por Cantidad"].Value?.ToString() ?? "", FontFactory.GetFont("Arial", 6))));
                                                tabla.AddCell(new PdfPCell(new Phrase(row.Cells["Fecha Venta"].Value?.ToString() ?? "", FontFactory.GetFont("Arial", 4))));
                                        }
                                        pdfDoc.Add(tabla);
                                        // Mostrar el total con fuente pequeña
                                        pdfDoc.Add(new Paragraph($"Total: {MyTotalVentaProductos.Text}", FontFactory.GetFont("Arial", "", Font.Bold)));
                                        pdfDoc.Close();
                                        stream.Close();
                                }
                        }
                }

                private void materialButton3_Click( object sender, EventArgs e ) {
                        using (db = new SeteaEntities1())
                        {
                                if (ventaEnCajaLista.Count > 0)
                                {
                                        foreach (VentaEnCaja item in ventaEnCajaLista)
                                        {
                                                producto productoActual = db.producto.FirstOrDefault(sf => sf.idProducto == item.idProdicto);
                                                item.FechaVenta = DateTime.Now;
                                                productoActual.cantidadRestante -= item.cantidadProducto;
                                                db.VentaEnCaja.Add(item);
                                                db.SaveChanges();
                                        }
                                } else
                                {
                                        MessageBox.Show("No hay productos que guardar");
                                }
                                if (EstaCajaEstaVacia(txtNombreCliente))
                                {
                                        ImpresionRecibo imprimirRecibo = new ImpresionRecibo(MyDataProductosCaja);
                                        imprimirRecibo.Imprimir();


                                        //GenerarFacturaVentas();

                                        txtNombreCliente.Text = "";
                                        TelefonoCompraCaja.Text = "";

                                        ventaEnCajaLista.Clear();

                                } else
                                {
                                        MessageBox.Show("Recuerde agregar el nombre del Cliente....");
                                        return;
                                }

                                //GenerarFacturaP80(MyDataProductosCaja);



                        }
                }

                private void materialButton7_Click( object sender, EventArgs e ) {
                        RegistrosVentas rgv = new RegistrosVentas();
                        Hide();
                        rgv.ShowDialog();
                        Show();
                }

                private void GenerarReporteDeProductos() {
                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.FileName = $"Reporte_Inventario_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm")}.pdf";

                        string filas = "";
                        int totalProductos = 0;
                        decimal valorTotalInventario = 0;

                        foreach (DataGridViewRow row in MyProducDg.Rows) // Asumiendo que tu DataGridView se llama MyProducDg
                        {
                                if (row.IsNewRow) continue;

                                // Obtener valores de las celdas
                                string idProducto = row.Cells["ID Producto"].Value?.ToString() ?? "";
                                string nombre = row.Cells["Nombre"].Value?.ToString() ?? "";

                                string descripcion = row.Cells["Descripcion"].Value?.ToString() ?? "x--x";
                                string precioUnidad = row.Cells["Precio Unidad"].Value?.ToString() ?? "0.0";
                                string cantidad = row.Cells["Cantidad Restante"].Value?.ToString() ?? "1";
                                string categoriaId = row.Cells["Categoria ID"].Value?.ToString() ?? "";
                                string fechaCreacion = row.Cells["Fecha Creacion"].Value?.ToString() ?? DateTime.Now.ToString();

                                // Calcular valores para el total
                                if (decimal.TryParse(precioUnidad, out decimal precio) && int.TryParse(cantidad, out int cant))
                                {
                                        valorTotalInventario += precio * cant;
                                }
                                totalProductos++;

                                // Construir filas HTML
                                filas += "<tr>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd\">{idProducto}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd\">{nombre}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd\">{descripcion}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd; text-align: right\">{precio.ToString("N2")}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd; text-align: right\">{cantidad}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd\">{categoriaId}</td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 1px solid #ddd\">{fechaCreacion}</td>";
                                filas += "</tr>";
                        }

                        string paginaHtml_text = Properties.Resources.PlantillaReportProductos.ToString();

                        // Reemplazar placeholders
                        paginaHtml_text = paginaHtml_text
                            .Replace("@Fecha", DateTime.Now.ToString("dd-MM-yyyy HH:mm"))
                            .Replace("@Filas", filas)
                            .Replace("@TotalProductos", totalProductos.ToString("N0"))
                            .Replace("@ValorTotal", valorTotalInventario.ToString("N2"))
                            .Replace("@ID", Guid.NewGuid().ToString().Substring(0, 8).ToUpper());

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

                private void CargarTodosLosProductosDesdeLaDb() {
                        using (db = new SeteaEntities1())
                        {
                                var query = db.producto.Where(ws => ws.Estado == "Activo").ToList();
                                productosLs.Clear();
                                foreach (var item in query)
                                {
                                        productosLs.Add(item);
                                }
                        }
                }

                private void materialButton2_Click_1( object sender, EventArgs e ) {
                        GenerarReporteDeProductos();
                }

                private void Fecha_ValueChanged( object sender, EventArgs e ) {
                        if (Fecha.Value == null)
                        {
                                return;
                        }
                        using (var db = new SeteaEntities1())
                        {
                                DateTime fechaSeleccionada = Fecha.Value.Date;
                                var query = db.producto
                                    .Where(v => DbFunctions.TruncateTime(v.FechaCreacion) == fechaSeleccionada)
                                    .ToList(); // Ejecutar la consulta
                                productosLs.Clear();
                                foreach (var item in query)
                                {
                                        productosLs.Add(item);
                                }
                        }
                }
                private void materialButton11_Click( object sender, EventArgs e ) {
                        CargarTodosLosProductosDesdeLaDb();
                }

                private void MyProducDg_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {
                                // Verifica que el click no sea en el encabezado
                                if (e.RowIndex >= 0)
                                {
                                        // Obtiene la fila clickeada
                                        DataGridViewRow fila = MyProducDg.Rows[e.RowIndex];

                                        // Obtiene el valor de la primera celda (ID)
                                        idProductoSeleccionadoEdicion = Convert.ToInt32(fila.Cells[0].Value);

                                        // Muestra el ID (corrigiendo el nombre de la variable)
                                        MessageBox.Show($"{idProductoSeleccionadoEdicion}");
                                }
                        } catch (Exception ex)
                        {
                                // Manejo de errores (opcionalmente puedes mostrar el error)
                                MessageBox.Show("Error al obtener el ID: " + ex.Message);
                        }
                }

                private void materialButton9_Click( object sender, EventArgs e ) {
                        if (idProductoSeleccionadoEdicion != 0)
                        {
                                Agregar_Editar_Producto agregarEditar = new Agregar_Editar_Producto(idProductoSeleccionadoEdicion);
                                Hide();
                                agregarEditar.ShowDialog();
                                ModificarDataGridProductos();
                                Show();

                        }
                }

                private void materialButton10_Click( object sender, EventArgs e ) {
                        Agregar_Editar_Producto agregarEditar = new Agregar_Editar_Producto();
                        Hide();
                        agregarEditar.ShowDialog();
                        ModificarDataGridProductos();
                        Show();
                }

                private void materialButton8_Click( object sender, EventArgs e ) {
                        if (idProductoSeleccionadoEdicion > 0)
                        {
                                using (var db = new SeteaEntities1())
                                {
                                        var proEliminar = db.producto.FirstOrDefault(sf => sf.idProducto == idProductoSeleccionadoEdicion);
                                        if (proEliminar == null)
                                        {
                                                MessageBox.Show("Producto no encontrado");
                                                return;
                                        }
                                        try
                                        {

                                                DialogResult resultado = MessageBox.Show(
                                                            $"El Producto ID: {proEliminar.idProducto} \n Nombre: {proEliminar.nombre} \n Será Eliminado",
                                                            "Confirmar eliminación",
                                                            MessageBoxButtons.OKCancel,
                                                            MessageBoxIcon.Warning);

                                                if (resultado == DialogResult.OK)
                                                {
                                                        // Si el usuario hace clic en OK
                                                        proEliminar.Estado = "Inactivo";
                                                        db.SaveChanges();
                                                } else
                                                {
                                                        // Si el usuario hace clic en Cancelar
                                                        MessageBox.Show("Eliminación cancelada");
                                                        // Aquí puedes agregar más lógica de cancelación
                                                }
                                                ModificarDataGridProductos();
                                        } catch (DbUpdateException ex)
                                        {
                                                MessageBox.Show("Error al eliminar el producto: " + ex.InnerException?.Message);
                                        }
                                }
                        } else
                        {
                                MessageBox.Show("No ha seleccionado ningún producto");
                        }
                }

                private void materialMultiLineTextBox21_TextChanged( object sender, EventArgs e ) {
                        using (var db = new SeteaEntities1()) // Se crea la instancia correctamente
                        {

                                var query = db.producto.Where(ws => ws.nombre.Contains(ProductoNombreFind.Text) && ws.Estado == "Activo");
                                productosLs.Clear();
                                foreach (var item in query)
                                {
                                        productosLs.Add(item);
                                }
                        }
                }

                private void ProductoNombreFind_Click( object sender, EventArgs e ) {

                }

                private void materialButton12_Click( object sender, EventArgs e ) {
                        ListaDeCompras listaDeCompras = new ListaDeCompras();
                        Hide();
                        listaDeCompras.ShowDialog();
                        Show();
                }

                private void ProductoVentaDescuento_TextChanged( object sender, EventArgs e ) {

                }

                private void CodigoDelProductoVenta_KeyDown( object sender, KeyEventArgs e ) {
                        if (e.KeyCode == Keys.Enter)
                        {
                                string codigo = CodigoDelProductoVenta.Text.Trim();
                                MessageBox.Show($"Codigo Escaneado {codigo} \n ");
                                CodigoDelProductoVenta.Text = codigo;
                                CargarProductos(codigo);
                                e.Handled = true;
                                e.SuppressKeyPress = true;
                        }
                }

                private void Paneles_SelectedIndexChanged( object sender, EventArgs e ) {

                }

                private void GestionCodigos_Click( object sender, EventArgs e ) {

                }

                private void materialLabel20_Click( object sender, EventArgs e ) {

                }

                private void materialButton13_Click( object sender, EventArgs e ) {
                        Codigos_Agregar_editar codigos_Agregar_Editar = new Codigos_Agregar_editar();
                        Hide();
                        codigos_Agregar_Editar.ShowDialog();
                        Show();
                        //CargarProductos();
                }

                private void s( object sender, EventArgs e ) {

                }
                private producto BusacarElObjetoPorElNombre( string NombreDelProducto ) {
                        using (db = new SeteaEntities1())
                        {
                                var query = db.producto.FirstOrDefault(x => x.nombre == NombreDelProducto);

                                if (query == null)
                                {
                                        MessageBox.Show("No se encontró ningún producto con el nombre proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return null;
                                }

                                return query;
                        }
                }

                private void MyProductos_TextChanged( object sender, EventArgs e ) {

                        var productoCargado = BusacarElObjetoPorElNombre(MyProductos.Text);

                        decimal precioUnidad = MyConversorGenerico.DeStringANumero<decimal>(productoCargado.PrecioUnidad.ToString());

                        numCantidadProducto.Maximum = MyConversorGenerico.DeStringANumero<decimal>(productoCargado.cantidadRestante.ToString());

                        myProductoPrecio.Text = productoCargado.PrecioUnidad.ToString();

                        txtPrecioTotalPorCantidad.Text = (precioUnidad * numCantidadProducto.Value).ToString();

                }

                private void BuscarPorCodigo_TextChanged( object sender, EventArgs e ) {
                        using (db = new SeteaEntities1())
                        {
                                // Limpia la lista
                                codigosDeProductosList.Clear();

                                // Filtra los resultados directamente desde la base de datos

                                var query = db.Codigo_De_Productos.Include(x => x.producto)
                                    .Where(x => x.CodigoDelProducto.Contains(BuscarPorCodigo.Text) || x.producto.nombre.Contains(BuscarPorCodigo.Text))
                                    .Select(x => new CodigosDeproductosShowsModels {
                                            ID_Producto = x.producto.idProducto,
                                            ID_Del_Codigo = x.ID,
                                            Nombre_Del_Producto = x.producto.nombre,
                                            Codigo_Del_Producto = x.CodigoDelProducto,
                                            Precio_Del_Producto = x.producto.PrecioUnidad,
                                            Cantidad_Restante = x.producto.cantidadRestante,
                                            Fecha_De_Creacion = (DateTime)x.Fecha_De_Agregacion
                                    })
                                    .ToList();

                                //Agrega los resultados a la lista de paroductos//

                                foreach (var item in query)
                                {
                                        codigosDeProductosList.Add(item);
                                }
                        }
                }

        }
}
