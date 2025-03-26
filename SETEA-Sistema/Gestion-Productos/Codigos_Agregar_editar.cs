using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Entidades;
using SETEA_Sistema.Modelodb;
using SETEA_Sistema.Utilidades;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema.Gestion_Productos
{
    public partial class Codigos_Agregar_editar : MaterialForm
    {
        BindingList<ProductoShowModels> lst = new BindingList<ProductoShowModels>();
        BindingList<Codigo_De_Productos> lstCodigos = new BindingList<Codigo_De_Productos>();
        public Codigos_Agregar_editar()
        {
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
        public Codigos_Agregar_editar(int id)
        {
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

        private void Codigos_Agregar_editar_Load(object sender, EventArgs e)
        {
            CargarListaConNombresDeProductos();
            CargarListaConLosCodigos();
        }
        private void CargarListaConLosCodigos()
        {
            lstCodigos.Clear();
            using (SeteaEntities1 db = new SeteaEntities1())
            {
                var query = db.Codigo_De_Productos.ToList();

                foreach (var item in query)
                {
                    Codigo_De_Productos newCodigo = item;
                    lstCodigos.Add(newCodigo);
                }
            }
            MyListaDeCodigos.DataSource = lstCodigos;
        }
        private void CargarListaConNombresDeProductos()
        {
            lst.Clear();
            using (SeteaEntities1 db = new SeteaEntities1())
            {
                var query = db.producto
                    .Select(p => new
                    {
                        p.idProducto,
                        p.nombre,
                        p.cantidadRestante,
                        p.PrecioUnidad

                    }).ToList();

                if (query == null)
                {
                    return;
                }
                foreach (var item in query)
                {
                    ProductoShowModels NuevoProducto = new ProductoShowModels
                    {
                        IdProducto = item.idProducto,
                        NombreProductp = item.nombre,
                        CantidadRestante = item.cantidadRestante,
                        PrecioUnidad = item.PrecioUnidad
                    };

                    lst.Add(NuevoProducto);
                }

                MyListaDeProductos.DataSource = lst;
            }

        }
        private void MyCodigoDeBarras_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MyCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string codigo = MyCodigoDeBarras.Text.Trim();
                MessageBox.Show($"Codigo Escaneado {codigo} \n Ahora seleccione un producto de la lista a la derecha para asignar el codigo");
                MyCodigoDeBarras.Text = codigo;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void AgregarCodigoAlaDB()
        {
            using (SeteaEntities1 db = new SeteaEntities1())
            {
                if (MyCodigoDeBarras.Text == "" && MyIdSeleccionadoTxt.Text == "")
                {
                    MessageBox.Show("Los dos campos deven (Codigo de producto y IdDelProducto) de estar llenos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    var query = db.Codigo_De_Productos.FirstOrDefault(x => x.CodigoDelProducto == MyCodigoDeBarras.Text);

                    if (query == null)
                    {
                        int myId = MyConversorGenerico.DeStringANumero<int>(MyIdSeleccionadoTxt.Text);
                        Codigo_De_Productos newCodigoDeProducto = new Codigo_De_Productos
                        {
                            CodigoDelProducto = MyCodigoDeBarras.Text,
                            Fecha_De_Agregacion = DateTime.Now,
                            ID_Producto_Enlazado = myId
                        };

                        var query2 = db.producto.FirstOrDefault(x => x.idProducto == myId);
                        if (query2 == null)
                        {
                            MessageBox.Show($"El producto con el id {myId} no existe...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        query2.cantidadRestante++;

                        db.Codigo_De_Productos.Add(newCodigoDeProducto);
                        db.SaveChanges();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Error Al Guardar El codigo {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AgregarCodigo_Click(object sender, EventArgs e)
        {
            AgregarCodigoAlaDB();
            CargarListaConNombresDeProductos();
            CargarListaConLosCodigos();

        }

        private void MyListaDeProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow fila = MyListaDeProductos.Rows[index];
                int IdSeleccionado = MyConversorGenerico.DeStringANumero<int>(fila.Cells["IdProducto"].Value.ToString());
                MessageBox.Show($"Has seleccionado el producto con el id {IdSeleccionado}", "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MyIdSeleccionadoTxt.Text = IdSeleccionado.ToString();
            }
        }

        private void MyListaDeCodigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow fila = MyListaDeCodigos.Rows[index];
                MyIdSeleccionadoTxt.Text = fila.Cells[2].Value.ToString();
                MyCodigoDeBarras.Text = fila.Cells[1].Value.ToString();
            }
        }

        private void EdicionCodigo_Click(object sender, EventArgs e)
        {
            DialogResult RespuestaDelMensaje = MessageBox.Show("Desea Editar Este Codigo ?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RespuestaDelMensaje == DialogResult.Yes)
            {
                using (SeteaEntities1 db = new SeteaEntities1())
                {
                    var query = db.Codigo_De_Productos.FirstOrDefault(x => x.CodigoDelProducto == MyCodigoDeBarras.Text);
                   
                    if (query == null)
                    {
                        MessageBox.Show("No se ha encontrado el Codigo seleccionado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int idSeleccionadaP = MyConversorGenerico.DeStringANumero<int>(MyIdSeleccionadoTxt.Text);
                    if (idSeleccionadaP <= 0)
                    {
                        MessageBox.Show("No hay un id Para enlazar el codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    query.ID_Producto_Enlazado = idSeleccionadaP;


                    var query2 = db.producto.FirstOrDefault(x => x.idProducto == idSeleccionadaP);

                    if(query2 == null)
                    {
                        MessageBox.Show("No hay un producto con ese id en los registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    query2.cantidadRestante++;

                    db.SaveChanges();

                    CargarListaConNombresDeProductos();

                    return;

                }

            }
            else
            {
                MessageBox.Show("Edicion Cancelada", "Canselar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
        }
    }
}
