using SETEA_Sistema.Entidades;
using SETEA_Sistema.Interfaces;
using SETEA_Sistema.Modelodb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETEA_Sistema.Utilidades.ReturnsBindingList
{
        internal class GetBinlingLIstClientesComboboxShow : GenericReturnBinlingList<ClienteEntityComboboBoxShow>
        {
                BindingList<ClienteEntityComboboBoxShow> Valores = new BindingList<ClienteEntityComboboBoxShow>();

                public override BindingList<ClienteEntityComboboBoxShow> GetBindingList() {


                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Cliente_RP.Select(x => new ClienteEntityComboboBoxShow {
                                                Cliente_ID = x.ID_Cliente_RP,
                                                Nombre_Del_Cliente = x.Nombre_Cliente_RP,
                                                Correo_Del_Cliente = x.Correo_Electronico_Cliente_RP,
                                        });

                                        if (query == null)
                                        {
                                                MessageBox.Show("No hay datos para mostrar en el ComboBox");
                                                return null;
                                        }
                                        Valores.Clear();
                                        foreach (var item in query)
                                        {
                                                Valores.Add(item);
                                        }
                                        return Valores;
                                }
                        }catch(Exception ex)
                        {
                                // Manejo de excepciones
                                Console.WriteLine("Error: " + ex.Message);
                        }


                        return null;
                }
        }
}
