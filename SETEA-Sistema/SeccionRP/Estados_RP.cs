using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Modelodb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETEA_Sistema.SeccionRP
{
        public partial class Estados_RP : MaterialForm
        {
                BindingList<Modelodb.Estados_RP> EstadosLST = new BindingList<Modelodb.Estados_RP>();
                public Estados_RP() {
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

                private void Estados_RP_Load( object sender, EventArgs e ) {
                        ActualizarTabla();
                }

                private void ActualizarTabla() {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Estados_RP.ToArray();
                                        if (query == null)
                                        {
                                                MessageBox.Show("La Lista de estados esta vacia, agerga un par", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                return;
                                        }
                                        EstadosLST.Clear();
                                        MyDataEstados.DataSource = null;
                                        foreach (var item in query)
                                        {
                                                EstadosLST.Add(item);
                                        }
                                        MyDataEstados.DataSource = EstadosLST;
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }

                private void CLearInfo() {
                        NombreEstado.Text = "";
                        DescriocionEstado.Text = "";

                }
                private void materialButton1_Click( object sender, EventArgs e ) {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var Estado_New = db.Estados_RP.Create();
                                        Estado_New.Estado = NombreEstado.Text;
                                        Estado_New.Descripcion = DescriocionEstado.Text;
                                        db.Estados_RP.Add(Estado_New);
                                        db.SaveChanges();
                                        ActualizarTabla();
                                        CLearInfo();

                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al Agergar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                int idEstado = 0;
                private void materialButton2_Click( object sender, EventArgs e ) {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        int id = idEstado; // Asumiendo que el ID se toma de un textbox
                                        var estadoExistente = db.Estados_RP.Find(id);

                                        if (estadoExistente != null)
                                        {
                                                estadoExistente.Estado = NombreEstado.Text;
                                                estadoExistente.Descripcion = DescriocionEstado.Text;
                                                db.SaveChanges();
                                                ActualizarTabla();
                                                CLearInfo();
                                        } else
                                        {
                                                MessageBox.Show("No se encontró el estado con el ID proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                }

                private void materialButton3_Click( object sender, EventArgs e ) {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        int id = idEstado; ; // El ID viene desde un TextBox o similar
                                        var estadoAEliminar = db.Estados_RP.Find(id);

                                        if (estadoAEliminar != null)
                                        {
                                                db.Estados_RP.Remove(estadoAEliminar);
                                                db.SaveChanges();
                                                ActualizarTabla();
                                                CLearInfo();
                                        } else
                                        {
                                                MessageBox.Show("No se encontró el estado con el ID indicado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al eliminar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                }

                private void MyDataEstados_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {
                                idEstado = (int)this.MyDataEstados.Rows[e.RowIndex].Cells[0].Value;
                                NombreEstado.Text = this.MyDataEstados.Rows[e.RowIndex].Cells[1].Value.ToString();
                                DescriocionEstado.Text = this.MyDataEstados.Rows[e.RowIndex].Cells[2].Value.ToString();
                                MessageBox.Show($"Has Seleccionado el Estado con el ID: {idEstado}", "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } catch (Exception err)
                        {
                                MessageBox.Show("Error al obtener el ID: " + err.Message);
                        }
                }

                private void materialTextBox22_TextChanged( object sender, EventArgs e ) {
                        try
                        {
                                using(SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Estados_RP
                                                .Where(x => x.Estado.Contains(materialTextBox22.Text))
                                                .ToList();
                                        if (query == null)
                                        {
                                                return;
                                        }
                                        EstadosLST.Clear();
                                        MyDataEstados.DataSource = null;
                                        foreach (var item in query)
                                        {
                                                EstadosLST.Add(item);
                                        }
                                        MyDataEstados.DataSource = EstadosLST;
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }

                private void MyDataEstados_DataError( object sender, DataGridViewDataErrorEventArgs e ) {

                }
        }
}
