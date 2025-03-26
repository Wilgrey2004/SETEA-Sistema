using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Modelodb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema.Gestion_Productos
{
        public partial class Agregar_Editar_Producto : MaterialForm
        {
                // BindingList
                private SeteaEntities1 db;
                public producto productoUs = new producto();
                private int IdProductoFind = 0;
                private List<string> categorias = new List<string>();
                public Agregar_Editar_Producto() {
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
                        SeccionName.Text = "Agrear Productp";
                        IDProducto.Visible = false;
                        LabelID.Visible = false;
                }

                public Agregar_Editar_Producto( int id ) {
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
                        SeccionName.Text = "Editar Producto";
                        IDProducto.Visible = true;
                        IDProducto.Text = id.ToString();
                        LabelID.Visible = true;
                        IdProductoFind = id;

                }

                private void CargarProductoEditar() {
                        if (IdProductoFind > 0)
                        {
                                using (db = new SeteaEntities1())
                                {

                                        productoUs = db.producto.FirstOrDefault(sf => sf.idProducto == IdProductoFind);
                                        if (productoUs != null)
                                        {
                                                NombreProducto.Text = productoUs.nombre;
                                                DescipcionProducto.Text = productoUs.descripcion;
                                                PrecioUnidadProducto.Text = productoUs.PrecioUnidad.ToString();
                                                CantidadProducto.Maximum = 10000;
                                                CantidadProducto.Value = Convert.ToDecimal(productoUs.cantidadRestante);


                                                IDProducto.Text = productoUs.idProducto.ToString();
                                                inicializarListaCategorias(productoUs);
                                        }
                                }

                        }
                }
                private void Agregar_Editar_Producto_Load( object sender, EventArgs e ) {
                        if (IdProductoFind > 0)
                        {
                                using (db = new SeteaEntities1())
                                {
                                        CargarProductoEditar();
                                }
                        } else
                        {
                                inicializarListaCategorias();
                        }
                }

                private void inicializarListaCategorias() {
                        CargarCategorias();
                }

                private void CargarCategorias() {
                        using (db = new SeteaEntities1())
                        {
                                var query = db.Categorias.Select(n => n.Nombre).ToList();

                                categorias = query;

                        }
                        CategoriaProducto.DataSource = categorias;

                }

                private void inicializarListaCategorias( producto proUs ) {

                        CargarCategorias();

                        using (db = new SeteaEntities1())
                        {
                                var nombreCategoria = db.Categorias
                                                        .Where(wf => wf.Id == proUs.categoriaId)
                                                        .Select(n => n.Nombre)
                                                        .FirstOrDefault(); // Obtiene el primer valor o null

                                CategoriaProducto.Text = nombreCategoria ?? "Categoría no encontrada";
                        }

                }
 
                private void materialButton1_Click( object sender, EventArgs e ) {
                        using (var db = new SeteaEntities1())
                        {
                                if (IdProductoFind > 0)
                                {
                                        // Recupera el objeto existente para editar
                                        var productoEditar = db.producto.FirstOrDefault(p => p.idProducto == IdProductoFind);
                                        if (productoEditar != null)
                                        {
                                                productoEditar.nombre = NombreProducto.Text;
                                                productoEditar.descripcion = DescipcionProducto.Text;
                                                productoEditar.PrecioUnidad = decimal.Parse(PrecioUnidadProducto.Text);
                                                productoEditar.cantidadRestante = Convert.ToInt32(CantidadProducto.Value);
                                                productoEditar.categoriaId = db.Categorias
                                                    .Where(c => c.Nombre == CategoriaProducto.Text)
                                                    .Select(c => c.Id)
                                                    .FirstOrDefault();
                                                productoEditar.FechaCreacion = DateTime.Now;
                                                // Si deseas, puedes actualizar también una fecha de modificación
                                                MessageBox.Show("Producto Actualizado");
                                        }
                                } else
                                {
                                        // Crear un nuevo objeto para agregar
                                        producto nuevoProducto = new producto {
                                                nombre = NombreProducto.Text,
                                                descripcion = DescipcionProducto.Text,
                                                PrecioUnidad = decimal.Parse(PrecioUnidadProducto.Text),
                                                cantidadRestante = Convert.ToInt32(CantidadProducto.Value),
                                                Estado = "Activo",
                                                categoriaId = db.Categorias
                                                .Where(c => c.Nombre == CategoriaProducto.Text)
                                                .Select(c => c.Id)
                                                .FirstOrDefault(),
                                                FechaCreacion = DateTime.Now
                                        };
                                        db.producto.Add(nuevoProducto);
                                        MessageBox.Show("Producto agregado");
                                }
                                db.SaveChanges();
                        }
                }

                private void materialButton2_Click( object sender, EventArgs e ) {

                }

                private void materialButton3_Click( object sender, EventArgs e ) {
                        NombreProducto.Text = string.Empty;
                        DescipcionProducto.Text= string.Empty;
                        PrecioUnidadProducto.Text = "0.00";
                        CantidadProducto.Value = 0;
                }
        }
}
