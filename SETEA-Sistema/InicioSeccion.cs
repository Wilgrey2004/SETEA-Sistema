using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Modelodb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema
{
        public partial class InicioSeccion : MaterialForm
        {
                public InicioSeccion() {
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

                private void InicioSeccion_Load( object sender, EventArgs e ) {

                }

                private void linkLabel1_LinkClicked( object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e ) {
                        Hide();
                        CreacionUsuario creacionUsuario = new CreacionUsuario();
                        creacionUsuario.ShowDialog();
                        Show();
                }

                private void materialButton1_Click( object sender, EventArgs e ) {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        if (string.IsNullOrWhiteSpace(UserCorreo.Text) ||
                                            string.IsNullOrWhiteSpace(UserPass.Text))
                                        {
                                                List<string> camposVacios = new List<string>();

                                                if (string.IsNullOrWhiteSpace(UserCorreo.Text))
                                                        camposVacios.Add("Correo");

                                                if (string.IsNullOrWhiteSpace(UserPass.Text))
                                                        camposVacios.Add("Contraseña");

                                                if (camposVacios.Count > 0)
                                                {
                                                        string mensaje = "Por favor, complete los siguientes campos:\n- " + string.Join("\n- ", camposVacios);
                                                        MessageBox.Show(mensaje, "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        return; // Detener la ejecución si hay campos vacíos
                                                }
                                        }

                                        var query = db.Usuarios.FirstOrDefault(x =>
                                                                                (x.Correo == UserCorreo.Text || x.Nombre == UserCorreo.Text)
                                                                                && x.Contraseña == UserPass.Text);
                                        if (query != null)
                                        {
                                                query.Ultima_Vez = DateTime.Now;
                                                db.SaveChanges();
                                                MessageBox.Show("Bienvenido", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                Gestion gs = new Gestion();
                                                Hide();
                                                gs.ShowDialog();
                                                Show();
                                        } else
                                        {
                                                MessageBox.Show("Correo o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show($"Error: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }

        }
}
