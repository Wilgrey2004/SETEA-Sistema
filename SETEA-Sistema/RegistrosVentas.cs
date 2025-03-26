using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Modelodb;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema
{
        public partial class RegistrosVentas : MaterialForm
        {
                private SeteaEntities1 db;
                private BindingList<VentaEnCaja> VentasEnCajalst = new BindingList<VentaEnCaja>();
                public RegistrosVentas() {

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

                        ModificarDataGridVentas(MyDataProductosCaja);
                        InicializarDataGrid();



                }


                private void CargarTotalLavel() {
                        double totalLabel = 0;
                        foreach (var item in VentasEnCajalst)
                        {
                                totalLabel += (double)item.precioPorCantidad;
                        }
                        LabelTotal.Text = $"Total de Ganancia RD:{totalLabel}";
                }

                private void InicializarDataGrid() {
                        VentasEnCajalst.Clear();
                        using (db = new SeteaEntities1())
                        {
                                var query = db.VentaEnCaja.ToList();

                                foreach (var item in query)
                                {
                                        VentasEnCajalst.Add(item);
                                }
                        }
                        MyDataProductosCaja.DataSource = VentasEnCajalst;
                        CargarTotalLavel();
                }
                private void RegistrosVentas_Load( object sender, EventArgs e ) {

                }
                private void ModificarDataGridVentas( DataGridView MyDataProductosCaja ) {
                        MyDataProductosCaja.AutoGenerateColumns = false;
                        MyDataProductosCaja.Columns.Clear();

                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "ID Venta",
                                DataPropertyName = "ID",   // Propiedad de tu objeto VentaEnCaja
                                HeaderText = "ID Venta"
                        });

                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Nombre Cliente",
                                DataPropertyName = "Nombre",   // Propiedad de tu objeto VentaEnCaja
                                HeaderText = "Nombre Cliente"
                        });
                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Nombre Del Producto",
                                DataPropertyName = "ProductoNombre", // Corregir el typo aquí
                                HeaderText = "Nombre Del Producto"
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
                                Name = "Fecha Venta",
                                DataPropertyName = "FechaVenta",  // Debes tener esta propiedad en tu clase VentaEnCaja
                                HeaderText = "Fecha Venta"
                        });

                        // Finalmente asigna la lista al DataSource
                        MyDataProductosCaja.DataSource = VentasEnCajalst;
                        CargarTotalLavel();
                }

                


                private void materialTextBox1_TextChanged( object sender, EventArgs e ) {
                        using (var db = new SeteaEntities1()) // Se crea la instancia correctamente
                        {

                                var query = db.VentaEnCaja.Where(ws => ws.Nombre.Contains(MyTextNameOrProduct.Text) || ws.ProductoNombre.Contains(MyTextNameOrProduct.Text));
                                VentasEnCajalst.Clear();
                                foreach (var item in query)
                                {
                                        VentasEnCajalst.Add(item);
                                }
                        }
                        CargarTotalLavel();
                }
                private void GeneradorDeReportesVenta() {

                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.FileName = $"Venta registro de la fecha y hora {DateTime.Now.ToString("ddmmyyyHHmm")}.pdf";
                        saveFile.ShowDialog();


                        string filas = "";

                        foreach (DataGridViewRow row in MyDataProductosCaja.Rows)
                        {
                                if (row.IsNewRow)
                                        continue; // Omite la fila en blanco que permite agregar nuevos registros.
                                string IDVenta = row.Cells["ID Venta"].Value?.ToString() ?? "";
                                string nombreCliente = row.Cells["Nombre Cliente"].Value?.ToString() ?? "";
                                string nombreProducto = row.Cells["Nombre Del Producto"].Value?.ToString() ?? "";
                                string idProdicto = row.Cells["id Prodicto"].Value?.ToString() ?? "";
                                string cantidadProducto = row.Cells["cantidad Producto"].Value?.ToString() ?? "";
                                string precioUnidad = row.Cells["Precio Unidad"].Value?.ToString() ?? "";
                                string precioPorCantidad = row.Cells["precio Por Cantidad"].Value?.ToString() ?? "";
                                string fechaVenta = row.Cells["Fecha Venta"].Value?.ToString() ?? "";

                                filas += "<tr>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; \"> {IDVenta} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; \"> {nombreCliente} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; \"> {nombreProducto} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; \"> {idProdicto} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; \"> {cantidadProducto} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; \"> {precioUnidad} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; \"> {precioPorCantidad} </td>";
                                filas += $"<td style=\"padding: 8px; border-bottom: 2px solid #ddd; \"> {fechaVenta} </td>";
                                filas += "</tr>";
                        }

                        
                        string paginaHtml_text = Properties.Resources.PlantillaReporteventas.ToString();

                        // Error en el formato (usa "-" en lugar de "/")
                        paginaHtml_text = paginaHtml_text.Replace("@Fecha", DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
                        paginaHtml_text = paginaHtml_text.Replace("@Filas", filas);
                        paginaHtml_text = paginaHtml_text.Replace("@Total", $"<span>{LabelTotal.Text}</span>");


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
                private void materialButton1_Click( object sender, EventArgs e ) {
                        InicializarDataGrid();
                }

                private void materialButton3_Click( object sender, EventArgs e ) {
                        MyTextNameOrProduct.Text = "";
                        InicializarDataGrid();
                }

                private void Fecha_ValueChanged( object sender, EventArgs e ) {
                        if (Fecha.Value == null) // Validar que Fecha.Value no sea nulo
                                return;

                        using (var db = new SeteaEntities1())
                        {
                                DateTime fechaSeleccionada = Fecha.Value.Date; // Obtener solo la fecha (sin hora)

                                // Comparar las fechas usando .Date (ignora la hora)
                                var query = db.VentaEnCaja
                                    .Where(v => DbFunctions.TruncateTime(v.FechaVenta) == fechaSeleccionada)
                                    .ToList(); // Ejecutar la consulta

                                // Aquí usarías los resultados (ej: asignar a un DataGrid)
                                VentasEnCajalst.Clear();
                                foreach (var item in query)
                                {
                                        VentasEnCajalst.Add(item);
                                }
                        }
                        CargarTotalLavel();
                }

                private void materialButton2_Click( object sender, EventArgs e ) {
                        GeneradorDeReportesVenta();
                }
        }
}
