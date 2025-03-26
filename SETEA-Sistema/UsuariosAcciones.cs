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

namespace SETEA_Sistema
{
        public partial class UsuariosAcciones : MaterialForm
        {
                public int id = 0;
                private Usuarios userAlter = new Usuarios();
                private SeteaEntities1 db;
                public UsuariosAcciones() {

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

                private void UsuariosAcciones_Load( object sender, EventArgs e ) {
                        using(db = new SeteaEntities1())
                        {
                                try
                                {
                                        if (id > 0)
                                        {
                                                userAlter = db.Usuarios.FirstOrDefault(user => user.Id == id);
                                                if(userAlter != null)
                                                {
                                                        this.Text = $"Usuario Seleccionado ID:{userAlter.Id} N:{userAlter.Nombre}";
                                                        UserId.Text = userAlter.Id.ToString();
                                                        nameUser.Text = userAlter.Nombre.ToString();
                                                        correoUser.Text = userAlter.Correo.ToString();
                                                        passUser.Text = userAlter.Contraseña.ToString();
                                                        fechaCreacionUser.Format = DateTimePickerFormat.Custom;
                                                        fechaCreacionUser.CustomFormat = "dd/MM/yyyy";
                                                        fechaCreacionUser.Value = (DateTime) userAlter.FechaCreacion;

                                                }
                                        }
                                } catch(Exception)
                                {
                                        return;
                                }
                        }
                }

                private void materialCard1_Paint( object sender, PaintEventArgs e ) {

                }

                private void Acceptar_Click( object sender, EventArgs e ) {
                        using (db = new SeteaEntities1())
                        {
                                userAlter = db.Usuarios.FirstOrDefault(user => user.Id == id);
                                if (userAlter != null)
                                {
                                        // Actualiza las propiedades del objeto con los valores de los controles
                                        // Nota: Generalmente el ID es inmutable, pero si fuera necesario, se puede asignar.
                                        // userAlter.Id = int.Parse(UserId.Text);

                                        userAlter.Nombre = nameUser.Text;
                                        userAlter.Correo = correoUser.Text;
                                        userAlter.Contraseña = passUser.Text;
                                        userAlter.FechaCreacion = fechaCreacionUser.Value;

                                        MessageBox.Show("Usuario actualizao, regrese a la pestaña anterior");
                                        db.SaveChanges();
                                }

                        }
                }
        }
}




