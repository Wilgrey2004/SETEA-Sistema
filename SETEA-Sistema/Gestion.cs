using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Entidades;
using SETEA_Sistema.Gestion_Productos;
using SETEA_Sistema.Modelodb;
using SETEA_Sistema.Utilidades;
using SETEA_Sistema.Utilidades.ReturnsBindingList;
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
                private BindingList<Usuarios> usl = new BindingList<Usuarios>();
                private string NumeroTelefonicoCliente = "";
                List<string> headersUsers = new List<string> { "ID", "Nombre", "Apellido", "Telefono", "Correo", "Fecha Creacion", "Rol" };
                List<string> headersVentas = new List<string> { "ID", "Nombre Cliente", "Telefono", "Nombre Del Producto", "codigo Del Producto", "id Prodicto", "cantidad Producto", "Precio Unidad", "precio Por Cantidad", "Descuento", "Fecha Venta" };
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
                                Name = "Nombre_cliente",
                                DataPropertyName = "Nombre_cliente",   // Propiedad de tu objeto VentaEnCaja
                                HeaderText = "Nombre cliente"
                        });
                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Telefono",
                                DataPropertyName = "NumeroDelCliente",
                                HeaderText = "Telefono"
                        });
                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "Nombre Del Producto",
                                DataPropertyName = "ProductoNombre",
                                HeaderText = "Nombre Del Producto"
                        });

                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "codigo Del Producto",
                                DataPropertyName = "codigoDelProducto",
                                HeaderText = "codigo Del Producto"
                        });

                        MyDataProductosCaja.Columns.Add(new DataGridViewTextBoxColumn {
                                Name = "id Prodicto",
                                DataPropertyName = "idProdicto",
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
                                usl.Clear();
                                usl = new BindingList<Usuarios>(db.Usuarios.ToList());
                                if (usl.Count > 0 && usl != null)
                                {
                                        MyDataUsers.DataSource = usl;
                                }
                        }

                        MyDataUsers.Columns["Roles"].Visible = false;
                }

                


                private void GenerarReporteUsuarios() {
                        var Mensaje = MessageBox.Show("Desea generar un reporte de usuarios ?", "Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (Mensaje == DialogResult.No)
                        {
                                return;
                        }
                        GeneradorDePdf.GeneradorDePDFS(usl, headersUsers, "Usuarios", "PlantillaReporteUsuarios");
                        MessageBox.Show("Reporte generado con exito", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                private void CargarTablaConRegistrosDiario() {
                        using (db = new SeteaEntities1())
                        {
                                usl.Clear();
                                var fechaHoy = DateTime.Today;
                                var query = db.Usuarios
                                        .Where(wh => wh.FechaCreacion.Value == fechaHoy)
                                        .ToList();

                                usl = new BindingList<Usuarios>(query);

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
                        using (db = new SeteaEntities1())
                        {
                                var query = db.producto.Where(x => x.cantidadRestante != 0).ToList();

                                foreach (var item in query)
                                {
                                        if (item.cantidadRestante > 0)
                                        {
                                                item.Estado = "Activo";

                                        } else
                                        {
                                                item.Estado = "Inactivo";
                                        }
                                }
                                productosLs.Clear();
                                productosLs = new BindingList<producto>(query);
                                MyProducDg.DataSource = productosLs;
                        }
                }
                private void CargarTablas() {
                        ActualizarTablaUser();
                        CargarTablaDeCodigos();
                        CargarLaListaDeProductosYcodigos();
                        CargarTablaProductos();
                }

                BindingList<CodigosProductosShowModels1> showsModelsCodigos = new BindingList<CodigosProductosShowModels1>();
                private void CargarLaListaDeProductosYcodigos() {

                        using (db = new SeteaEntities1())
                        {

                                var query = db.Codigo_De_Productos
                                        .Include(x => x.producto)
                                        .Where(x => x.Estado_Codigo == "Activo")
                                        .Select(x => new CodigosProductosShowModels1 {
                                                ID_Del_Codigo = x.ID,
                                                ID_Del_Producto = x.producto.idProducto,
                                                Codigo = x.CodigoDelProducto,
                                                Nombre_Del_Producto = x.producto.nombre,
                                                Precio_Unidad = x.producto.PrecioUnidad

                                        }).ToList();

                                if (query == null)
                                {
                                        return;
                                }
                                showsModelsCodigos.Clear();
                                showsModelsCodigos = new BindingList<CodigosProductosShowModels1>(query);
                                MyListProductos.DataSource = showsModelsCodigos;
                        }

                }

                private BindingList<CodigosDeproductosShowsModels> codigosDeProductosList = new BindingList<CodigosDeproductosShowsModels>();

                private void CargarTablaDeCodigos() {
                        codigosDeProductosList.Clear();
                        GetBindingListcodigosShowModels getBindingListCodigos = new GetBindingListcodigosShowModels();
                        var query = getBindingListCodigos.GetBindingList();

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
                private void Gestion_Load( object sender, EventArgs e ) {
                        this.KeyPreview = true;
                        CargarTablas();
                        AlterDatagrids();
                        numCantidadProducto.Minimum = 1;
                        // CargarProductos();
                }

                private void AlterDatagrids() {
                        Configurador_DataGrid.ConfiguracionDelDataGrid(MyDataProductosCaja);
                        Configurador_DataGrid.ConfiguracionDelDataGrid(ListaDecodigosProductos, 70);
                        Configurador_DataGrid.ConfiguracionDelDataGrid(MyDataUsers, 50);
                        Configurador_DataGrid.ConfiguracionDelDataGrid(MyDataProductosCaja, 50);
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
                        var query = ventaEnCajaLista.FirstOrDefault(x => x.codigoDelProducto == CodigoDelProductoVenta.Text);

                        if (query != null)
                        {
                                MessageBox.Show("Ya hay un producto con ese codigo agregado a la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                        }



                        int descuento_ = MyConversorGenerico.DeStringANumero<int>(ProductoVentaDescuento.Text) == 0 ? 0 : MyConversorGenerico.DeStringANumero<int>(ProductoVentaDescuento.Text);
                        decimal precioUnidad_ = MyConversorGenerico.DeStringANumero<decimal>(myProductoPrecio.Text);
                        decimal precioPorCantidad_ = MyConversorGenerico.DeStringANumero<decimal>(txtPrecioTotalPorCantidad.Text);
                        int cantidadProducto_ = Convert.ToInt32(numCantidadProducto.Value);

                        NumeroTelefonicoCliente = TelefonoCompraCaja.Text;
                        decimal precioFinalUnidad = descuento_ == 0 ? precioUnidad_ : precioUnidad_ - (precioUnidad_ * (descuento_ / 100m));
                        int idProducto = 0;
                        using (db = new SeteaEntities1())
                        {
                                var productoNombrePorId = db.producto.FirstOrDefault(x => x.nombre == MyProductos.Text);

                                if (productoNombrePorId != null)
                                {
                                        idProducto = productoNombrePorId.idProducto;
                                }
                        }
                        VentaEnCaja nuevaVenta = new VentaEnCaja {

                                idProdicto = idProducto,
                                codigoDelProducto = CodigoDelProductoVenta.Text,
                                Nombre_cliente = txtNombreCliente.Text == string.Empty ? "No nombre del cliente" : txtNombreCliente.Text,
                                ProductoNombre = string.IsNullOrEmpty(MyProductos.Text) ? "No nombre del Producto" : MyProductos.Text,
                                NumeroDelCliente = string.IsNullOrEmpty(NumeroTelefonicoCliente) ? "No numero" : NumeroTelefonicoCliente,
                                cantidadProducto = cantidadProducto_,
                                PrecioUnidad = precioFinalUnidad,
                                Descuento = descuento_,
                                precioPorCantidad = precioPorCantidad_,
                                FechaVenta = DateTime.UtcNow
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



                private bool EstaCajaEstaVacia( MaterialTextBox2 textBox ) {
                        return textBox.Text != "";
                }


                private void materialButton3_Click( object sender, EventArgs e ) {
                        using (db = new SeteaEntities1())
                        {
                                GeneradorDePdf gneradorDePdf = new GeneradorDePdf();

                                if (ventaEnCajaLista.Count > 0)
                                {
                                        foreach (VentaEnCaja item in ventaEnCajaLista)
                                        {
                                                producto productoActual = db.producto.FirstOrDefault(sf => sf.idProducto == item.idProdicto); // Verifica el nombre correcto
                                                item.FechaVenta = DateTime.Now;
                                                if (productoActual.cantidadRestante < item.cantidadProducto)
                                                {
                                                        MessageBox.Show($"No hay suficiente cantidad del producto {productoActual.nombre}");
                                                        return;
                                                } else
                                                {
                                                        productoActual.cantidadRestante -= item.cantidadProducto;
                                                }
                                                db.VentaEnCaja.Add(item);

                                        }
                                } else
                                {
                                        MessageBox.Show("No hay productos que guardar");
                                }
                                ImpresionRecibo imprimirRecibo = new ImpresionRecibo(MyDataProductosCaja);
                                imprimirRecibo.Imprimir();
                                var Mensaje = MessageBox.Show("Desea Guardar un reporte de esta venta ?", "Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Mensaje == DialogResult.No)
                                {
                                        return;
                                }
                                GetBindingListVentaModelsShow getVenshow = new GetBindingListVentaModelsShow();
                                var nuevaLista = getVenshow.GetBindingListApartirDeOtra(ventaEnCajaLista);
                                GeneradorDePdf.GeneradorDePDFS(nuevaLista, headersVentas, "Ventas", "PlantillaFactura", MyConversorGenerico.DeStringANumero<decimal>(MyTotalVentaProductos.Text));
                                MessageBox.Show("Reporte generado con exito", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                foreach (var item in ventaEnCajaLista)
                                {
                                        var codigoADesactivar = db.Codigo_De_Productos.FirstOrDefault(x => x.CodigoDelProducto == item.codigoDelProducto);
                                        if (codigoADesactivar != null)
                                        {
                                                codigoADesactivar.Estado_Codigo = "Inactivo";
                                        }
                                }

                                try
                                {
                                        db.SaveChanges();
                                } catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                                {
                                        foreach (var errors in ex.EntityValidationErrors)
                                        {
                                                foreach (var error in errors.ValidationErrors)
                                                {
                                                        MessageBox.Show($"Error en {error.PropertyName}: {error.ErrorMessage}");
                                                }
                                        }
                                        throw; // Opcional: relanzar para ver el error completo en depuración
                                }
                                txtNombreCliente.Text = "";
                                TelefonoCompraCaja.Text = "";
                                ventaEnCajaLista.Clear();
                                CargarTablas();



                        }
                }

                private void materialButton7_Click( object sender, EventArgs e ) {
                        Gestion_Ventas gv = new Gestion_Ventas();
                        Hide();
                        gv.ShowDialog();
                        Show();
                }
                private List<string> HeadersProductos = new List<string> { "ID", "Nombre", "Descripcion", "Cantidad", "Precio", "Categoria", "Estado", "Fecha" };



                private void GenerarReporteDeProductos() {
                        var mensajeAprovar = MessageBox.Show("Desea generar un reporte de productos ?", "Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (mensajeAprovar == DialogResult.No)
                        {
                                return;
                        }
                        decimal? totalProductosGanancia = 0;
                        GetBindingListProductoShowsModels GetBindingListPro = new GetBindingListProductoShowsModels();
                        BindingList<ProductoReporteModelShows> productosReporte = new BindingList<ProductoReporteModelShows>(GetBindingListPro.GetBindingList());
                        foreach (var item in productosReporte)
                        {
                                totalProductosGanancia += item.Precio_Unidad;
                        }
                        string totalString = totalProductosGanancia.ToString();
                        GeneradorDePdf.GeneradorDePDFS(productosReporte, HeadersProductos, "Productos", "PlantillaReportProductos", totalProductosGanancia);
                        MessageBox.Show("Reporte generado con exito", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                List<string> HeaderCodigos = new List<string> { "ID Codigo", "ID Del producto", "Nombre del producto", "Codigo", "Cantidad restante", "Precio unidad", "Fecha de creacio" };

                private void GenerarReporteDeCodigo() {
                        var mensajeAprovar = MessageBox.Show("Desea generar un reporte de Codigos ?", "Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (mensajeAprovar == DialogResult.No)
                        {
                                return;
                        }

                        GeneradorDePdf.GeneradorDePDFS(codigosDeProductosList, HeaderCodigos, "Codigos", "PlantillaReportProductos");
                        MessageBox.Show("Reporte generado con exito", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                private void CargarTodosLosProductosDesdeLaDb() {
                        using (db = new SeteaEntities1())
                        {
                                var query = db.producto.Where(ws => ws.Estado == "Activo").ToList();
                                productosLs.Clear();
                                productosLs = new BindingList<producto>(query);
                        }
                }

                private void materialButton2_Click_1( object sender, EventArgs e ) {
                        GenerarReporteDeProductos();
                }

                private void Fecha_ValueChanged( object sender, EventArgs e ) {
                        using (var db = new SeteaEntities1())
                        {
                                DateTime fechaSeleccionada = Fecha.Value.Date;
                                // Se filtran productos que coincidan con la fecha y estén activos
                                var query = db.producto
                                                .Where(v => DbFunctions.TruncateTime(v.FechaCreacion) == fechaSeleccionada && v.cantidadRestante > 0)
                                                .ToList();
                                // Se crea la lista de BindingList a partir de los resultados filtrados
                                productosLs = new BindingList<producto>(query);
                                MyProducDg.DataSource = productosLs;
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
                        CargarTablas();
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

                                var query = db.producto.Where(ws => ws.nombre.Contains(BuscarPorCodigo.Text) && ws.Estado == "Activo");
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

                                CodigoDelProductoVenta.Text = codigo;


                                CargarProductos(codigo);

                                MessageBox.Show($"Codigo Escaneado {codigo} \n ");

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
                        codigos_Agregar_Editar.Encabezado.Text.Replace("@acciones", "Agregar");
                        codigos_Agregar_Editar.ShowDialog();
                        CargarTablas();
                        Show();
                }
                private producto BusacarElObjetoPorElNombre( string NombreDelProducto ) {

                        if (NombreDelProducto == null) return null;

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
                        if (MyProductos.Text == null) return;

                        var productoCargado = BusacarElObjetoPorElNombre(MyProductos.Text);

                        if (productoCargado == null) return;

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

                private void MyListProductos_MouseEnter( object sender, EventArgs e ) {

                }

                private void MyListProductos_MouseMove( object sender, MouseEventArgs e ) {


                }

                private void MyListProductos_MouseClick( object sender, MouseEventArgs e ) {

                }

                private void MyListProductos_SelectedIndexChanged( object sender, EventArgs e ) {

                }

                private void MyListProductos_Click( object sender, EventArgs e ) {
                        if (MyListProductos.SelectedItem == null)
                        {
                                MessageBox.Show("No ha seleccionado ningún producto");
                                return;
                        }

                        var selectedItem = MyListProductos.SelectedItem;

                        if (selectedItem == null)
                        {
                                MessageBox.Show("segunda comprovacion No ha seleccionado ningun producto");
                                return;
                        }

                        if (selectedItem is CodigosProductosShowModels1 codigoProducto)
                        {
                                CodigoDelProductoVenta.Text = codigoProducto.Codigo;
                                MyProductos.Text = codigoProducto.Nombre_Del_Producto;
                        }
                }

                private void dateTimePicker1_ValueChanged( object sender, EventArgs e ) {



                        using (var db = new SeteaEntities1())
                        {
                                DateTime fechaSeleccionada = dateTimePicker1.Value.Date;

                                var query = db.Codigo_De_Productos.Include(x => x.producto)
                                        .Where(x => x.Estado_Codigo == "Activo" &&
                                                        DbFunctions.TruncateTime(x.Fecha_De_Agregacion) == fechaSeleccionada)
                                        .Select(x => new CodigosDeproductosShowsModels {
                                                ID_Producto = x.producto.idProducto,
                                                ID_Del_Codigo = x.ID,
                                                Nombre_Del_Producto = x.producto.nombre,
                                                Codigo_Del_Producto = x.CodigoDelProducto,
                                                Precio_Del_Producto = x.producto.PrecioUnidad,
                                                Cantidad_Restante = x.producto.cantidadRestante,
                                                Fecha_De_Creacion = x.Fecha_De_Agregacion ?? DateTime.MinValue
                                        }
                                );
                                codigosDeProductosList.Clear();
                                foreach (var item in query)
                                {
                                        codigosDeProductosList.Add(item);
                                }
                                ListaDecodigosProductos.DataSource = codigosDeProductosList;
                        }
                }

                private void materialButton20_Click( object sender, EventArgs e ) {
                        CargarTablas();
                }

                private void materialButton15_Click( object sender, EventArgs e ) {
                        if (IdDelCodigoseleccionado == 0)
                        {
                                MessageBox.Show("No ha seleccionado ningun codigo");
                                return;
                        }

                        var mensajeAprovar = MessageBox.Show("Desea Editar el codigo con el id " + IdDelCodigoseleccionado + "?", "Desactivar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (mensajeAprovar == DialogResult.No)
                        {
                                return;
                        }

                        Codigos_Agregar_editar codigos_Agregar_Editar = new Codigos_Agregar_editar(IdDelCodigoseleccionado);
                        Hide();
                        codigos_Agregar_Editar.idCargada = IdDelCodigoseleccionado;

                        codigos_Agregar_Editar.ShowDialog();
                        CargarTablas();
                        Show();

                }
                int IdDelCodigoseleccionado = 0;
                private void ListaDecodigosProductos_CellClick( object sender, DataGridViewCellEventArgs e ) {

                        try
                        {
                                IdDelCodigoseleccionado = (int)this.ListaDecodigosProductos.Rows[e.RowIndex].Cells["ID_Del_Codigo"].Value;
                                MessageBox.Show($"Has Seleccionado el codigo con el ID: {IdDelCodigoseleccionado}", "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } catch (Exception err)
                        {
                                MessageBox.Show("Error al obtener el ID: " + err.Message);
                        }

                }

                private void materialButton14_Click( object sender, EventArgs e ) {
                        if (IdDelCodigoseleccionado == 0)
                        {
                                MessageBox.Show("No ha seleccionado ningun codigo");
                                return;
                        }

                        var mensajeAprovar = MessageBox.Show("Desea Eliminar el codigo con el id " + IdDelCodigoseleccionado + "?", "Desactivar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (mensajeAprovar == DialogResult.No)
                        {
                                return;
                        }

                        using (var db = new SeteaEntities1())
                        {
                                var codigo = db.Codigo_De_Productos.Include(x => x.producto).FirstOrDefault(x => x.ID == IdDelCodigoseleccionado);
                                if (codigo == null)
                                {
                                        return;
                                }
                                codigo.Estado_Codigo = "Inactivo";
                                codigo.producto.cantidadRestante--;
                                db.SaveChanges();
                        }
                        CargarTablas();
                }

                private void materialTextBox21_TextChanged( object sender, EventArgs e ) {
                        using (db = new SeteaEntities1())
                        {
                                // Limpia la lista
                                usl.Clear();

                                // Filtra los resultados directamente desde la base de datos

                                var query = db.Usuarios.Where(x => x.Nombre.Contains(materialTextBox21.Text) || x.Correo.Contains(materialTextBox21.Text)).ToList();


                                //Agrega los resultados a la lista de paroductos//

                                usl = new BindingList<Usuarios>(query);
                                MyDataUsers.DataSource = usl;
                        }


                }

                private void materialButton21_Click( object sender, EventArgs e ) {
                        CargarTablas();
                }

                private void materialButton22_Click( object sender, EventArgs e ) {
                        CargarTablas();
                }

                private void materialLabel30_Click( object sender, EventArgs e ) {

                }

                private void ProductoNombreFind_TextChanged( object sender, EventArgs e ) {
                        using (db = new SeteaEntities1())
                        {

                                var query = db.producto.Where(x => x.nombre.Contains(ProductoNombreFind.Text) && x.cantidadRestante > 0).ToList();
                                if (query == null)
                                {
                                        MessageBox.Show("No se encontraron productos con el nombre proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                }
                                productosLs.Clear();
                                productosLs = new BindingList<producto>(query);
                                MyProducDg.DataSource = productosLs;
                        }
                }

                private void ProductoNombreFind_TextAlignChanged( object sender, EventArgs e ) {

                }

                private void materialButton16_Click( object sender, EventArgs e ) {
                        GenerarReporteDeCodigo();
                }
        }
}
