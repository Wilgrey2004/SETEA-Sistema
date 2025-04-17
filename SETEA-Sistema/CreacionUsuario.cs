using EmisorDeCorreosDeVerificacion;
using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.CodigoDeVerificacion;
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

namespace SETEA_Sistema
{
        public partial class CreacionUsuario : MaterialForm
        {
                public CreacionUsuario() {
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

                private void CreacionUsuario_Load( object sender, EventArgs e ) {

                }

                private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e ) {
                        this.Close();
                        InicioSeccion inicioSeccion = new InicioSeccion();      
                        inicioSeccion.Show();
                        
                }

                private void materialButton1_Click( object sender, EventArgs e ) {
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                if (string.IsNullOrWhiteSpace(NewName.Text) ||
                                    string.IsNullOrWhiteSpace(NewCorreo.Text) ||
                                    string.IsNullOrWhiteSpace(NewPass.Text))
                                {
                                        List<string> camposVacios = new List<string>();

                                        if (string.IsNullOrWhiteSpace(NewName.Text))
                                                camposVacios.Add("Nombre");

                                        if (string.IsNullOrWhiteSpace(NewCorreo.Text))
                                                camposVacios.Add("Correo");

                                        if (string.IsNullOrWhiteSpace(NewPass.Text))
                                                camposVacios.Add("Contraseña");

                                        if (camposVacios.Count > 0)
                                        {
                                                string mensaje = "Por favor, complete los siguientes campos:\n- " + string.Join("\n- ", camposVacios);
                                                MessageBox.Show(mensaje, "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return; // Detener la ejecución si hay campos vacíos
                                        }
                                }

                                // Si todos los campos están llenos, ejecuta tu lógica aquí
                                Usuarios usuarios = new Usuarios {
                                        Nombre = NewName.Text,
                                        Correo = NewCorreo.Text,
                                        Contraseña = NewPass.Text,
                                        RolId = 1,
                                        FechaCreacion = DateTime.Now
                                };


                                // Verificar si el correo ya existe
                                if (db.Usuarios.Any(u => u.Correo == NewCorreo.Text))
                                {
                                        MessageBox.Show("El correo ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                }

                                int codigoDeVerificacion = new EmisorReceptorGmail().Enviar("greymoon20041010@gmail.com", "dxjf ywzf pboe vpvi", "apro24470@gmail.com");
                                int codigoRecibido = 0;
                                ReceptorDeCodigoShow receptorDeCodigoShow = new ReceptorDeCodigoShow();
                                receptorDeCodigoShow.ShowDialog();
                                codigoRecibido = receptorDeCodigoShow.codigo;
                                if(codigoRecibido == -1)
                                {
                                        MessageBox.Show("has cancelado la operacion");
                                        return;
                                }

                                if(codigoRecibido != codigoDeVerificacion)
                                {
                                        MessageBox.Show("El codigo no es correcto");
                                        return;
                                }

                                db.Usuarios.Add(usuarios);
                                db.SaveChanges();
                                MessageBox.Show("Usuario Agregado, Regrese a el Loging");
                        }
                }
        }
}
