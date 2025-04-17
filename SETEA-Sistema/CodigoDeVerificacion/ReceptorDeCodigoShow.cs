using MaterialSkin;
using MaterialSkin.Controls;
using SETEA_Sistema.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETEA_Sistema.CodigoDeVerificacion
{
        public partial class ReceptorDeCodigoShow : MaterialForm
        {
                public int codigo = 0;
                public ReceptorDeCodigoShow() {
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

                private void ReceptorDeCodigoShow_Load( object sender, EventArgs e ) {
                        MessageBox.Show("El codigo fue enviado al correo del administrador");
                }

                private void materialButton2_Click( object sender, EventArgs e ) {
                        try
                        {
                                codigo = MyConversorGenerico.DeStringANumero<int>(MyCodigoDeConfimacionTxt.Text);
                                Close();
                        }catch(Exception ex)
                        {
                                MessageBox.Show("Vuelva a ingresre el codigo \n codigo de error: " + ex.Message);
                                MyCodigoDeConfimacionTxt.Text = "";
                                return;
                        }
                }

                private void materialButton1_Click( object sender, EventArgs e ) {
                        codigo = -1;
                        MessageBox.Show("has cancelado la operacion");
                        Close();
                }
        }
}
