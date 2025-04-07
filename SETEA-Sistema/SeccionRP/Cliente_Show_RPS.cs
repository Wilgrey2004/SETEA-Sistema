using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Modelodb;
using SETEA_Sistema.Utilidades;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema.SeccionRP
{
        public partial class Cliente_Show_RPS : MaterialForm
        {
                BindingList<Cliente_RP> clientesLST = new BindingList<Cliente_RP>();
                public Cliente_Show_RPS() {
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

                private void Cliente_Show_RPS_Load( object sender, EventArgs e ) {
                        ActualizarInformacion();
                        Configurador_DataGrid.ConfiguracionDelDataGrid(MyClienteInfoDG);
                }
                private void ActualizarInformacion() {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Cliente_RP.ToList();
                                        if (query.Count == 0)
                                        {
                                                MessageBox.Show("No hay clientes registrados");
                                                return;
                                        }
                                        clientesLST.Clear();
                                        foreach (var item in query)
                                        {
                                                clientesLST.Add(item);
                                        }
                                        MyClienteInfoDG.DataSource = clientesLST;

                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error: " + ex.Message);
                                return;
                        }
                }
                private void ClearInfo() {
                        NombreCliente.Text = "";
                        TelefonoCliente.Text = "";
                        CorreoCliente.Text = "";
                        DireccionCliente.Text = "";
                }

                private void materialButton1_Click( object sender, EventArgs e ) {
                        try
                        {
                                var message = MessageBox.Show("Deseas Agrear el cliente?", "Agregar Cliente", MessageBoxButtons.YesNo);
                                if (message == DialogResult.No)
                                {
                                        return;
                                }
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        Cliente_RP cliente_New = new Cliente_RP();
                                        if (NombreCliente.Text == "")
                                        {
                                                MessageBox.Show("Nombre del Cliente es necesario");
                                                return;
                                        }

                                        var query = db.Cliente_RP.FirstOrDefault(x => x.Correo_Electronico_Cliente_RP == CorreoCliente.Text);
                                        if (query != null)
                                        {
                                                MessageBox.Show("Ya existe un cliente con ese correo");
                                                return;
                                        }

                                        cliente_New.Nombre_Cliente_RP = string.IsNullOrWhiteSpace(NombreCliente.Text) ? "Nombre no especificado" : NombreCliente.Text;
                                        cliente_New.Numero_Cliente_RP = string.IsNullOrWhiteSpace(TelefonoCliente.Text) ? "Teléfono no especificado" : TelefonoCliente.Text;
                                        cliente_New.Correo_Electronico_Cliente_RP = string.IsNullOrWhiteSpace(CorreoCliente.Text) ? "Correono@especificado" : CorreoCliente.Text;
                                        cliente_New.Fecha_Registro = DateTime.Now;
                                        cliente_New.Direccion_Cliente = string.IsNullOrWhiteSpace(DireccionCliente.Text) ? "Dirección no especificada" : DireccionCliente.Text;
                                        db.Cliente_RP.Add(cliente_New);
                                        db.SaveChanges();
                                        ActualizarInformacion();
                                        MessageBox.Show("Se ha creado el cliente con exito");
                                        ClearInfo();


                                }

                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error: " + ex.Message);
                                return;
                        }

                }

                private void MyClienteInfoDG_CellContentClick( object sender, DataGridViewCellEventArgs e ) {

                }
                int idInfo = 0;
                private void MyClienteInfoDG_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {
                                if (e.RowIndex >= 0)
                                {
                                        DataGridViewRow fila = MyClienteInfoDG.Rows[e.RowIndex];

                                        idInfo = Convert.ToInt32(fila.Cells[0].Value);
                                        NombreCliente.Text = fila.Cells[1].Value?.ToString() ?? "";
                                        TelefonoCliente.Text = fila.Cells[2].Value?.ToString() ?? "";
                                        CorreoCliente.Text = fila.Cells[3].Value?.ToString() ?? "";
                                        DireccionCliente.Text = fila.Cells[4].Value?.ToString() ?? "";

                                        // Si quieres formatear la fecha o simplemente mostrarla:
                                        FechaCliente.Value =Convert.ToDateTime(fila.Cells[5].Value);

                                        MessageBox.Show($"Has seleccionado la información del cliente con el id: {idInfo} y el nombre {NombreCliente.Text}");
                                }
                        } catch (Exception)
                        {
                                MessageBox.Show("Error al seleccionar la info...");
                        }

                }

                private void MyClienteInfoDG_DataError( object sender, DataGridViewDataErrorEventArgs e ) {

                }

                private void materialFloatingActionButton1_Click( object sender, EventArgs e ) {
                        ClearInfo();
                }

                private void materialButton2_Click( object sender, EventArgs e ) {
                        try
                        {
                                var message = MessageBox.Show("¿Deseas actualizar el cliente?", "Actualizar Cliente", MessageBoxButtons.YesNo);
                                if (message == DialogResult.No)
                                {
                                        return;
                                }

                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var clienteExistente = db.Cliente_RP.FirstOrDefault(x => x.ID_Cliente_RP == idInfo);
                                        if (clienteExistente == null)
                                        {
                                                MessageBox.Show("No se encontró el cliente a actualizar.");
                                                return;
                                        }

                                        if (string.IsNullOrWhiteSpace(NombreCliente.Text))
                                        {
                                                MessageBox.Show("El nombre del cliente es obligatorio.");
                                                return;
                                        }

                                        

                                        // Actualizar los campos
                                        clienteExistente.Nombre_Cliente_RP = string.IsNullOrWhiteSpace(NombreCliente.Text) ? "Nombre no especificado" : NombreCliente.Text;
                                        clienteExistente.Numero_Cliente_RP = string.IsNullOrWhiteSpace(TelefonoCliente.Text) ? "Teléfono no especificado" : TelefonoCliente.Text;
                                        clienteExistente.Correo_Electronico_Cliente_RP = string.IsNullOrWhiteSpace(CorreoCliente.Text) ? "Correono@especificado" : CorreoCliente.Text;
                                        clienteExistente.Direccion_Cliente = string.IsNullOrWhiteSpace(DireccionCliente.Text) ? "Dirección no especificada" : DireccionCliente.Text;
                                        clienteExistente.Fecha_Registro = DateTime.Now;

                                        db.SaveChanges();
                                        ActualizarInformacion();
                                        MessageBox.Show("Cliente actualizado con éxito.");
                                        ClearInfo();
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al actualizar: " + ex.Message);
                                return;
                        }
                }

                private void materialButton3_Click( object sender, EventArgs e ) {
                        try
                        {
                                var message = MessageBox.Show("¿Deseas eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo);
                                if (message == DialogResult.No)
                                {
                                        return;
                                }

                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var clienteEliminar = db.Cliente_RP.FirstOrDefault(x => x.ID_Cliente_RP == idInfo);
                                        if (clienteEliminar == null)
                                        {
                                                MessageBox.Show("No se encontró el cliente a eliminar.");
                                                return;
                                        }

                                        db.Cliente_RP.Remove(clienteEliminar);
                                        db.SaveChanges();

                                        ActualizarInformacion();
                                        MessageBox.Show("Cliente eliminado con éxito.");
                                        ClearInfo();
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al eliminar: " + ex.Message);
                                return;
                        }

                }

                private void ProductoNombreFind_TextChanged( object sender, EventArgs e ) {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Cliente_RP
                                            .Where(x => x.Nombre_Cliente_RP.Contains(ProductoNombreFind.Text) ||
                                                        x.Numero_Cliente_RP.Contains(ProductoNombreFind.Text) ||
                                                        x.Correo_Electronico_Cliente_RP.Contains(ProductoNombreFind.Text))
                                            .ToList();

                                        clientesLST.Clear(); // Asegúrate de que clientesLST sea una lista compatible
                                        foreach (var item in query)
                                        {
                                                clientesLST.Add(item);
                                        }

                                        MyClienteInfoDG.DataSource = null; // Limpia el DataGridView si es necesario
                                        MyClienteInfoDG.DataSource = clientesLST;
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al buscar clientes: " + ex.Message);
                                return;
                        }
                }

        }
}
