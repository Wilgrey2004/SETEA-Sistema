using SETEA_Sistema.Entidades;
using SETEA_Sistema.Interfaces;
using SETEA_Sistema.Modelodb;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema.Utilidades.ReturnsBindingList
{
        internal class GetBindingListEstadoComboboxModelsShow : GenericReturnBinlingList<EstadosEntityComboboxModelsShow>
        {
                BindingList<EstadosEntityComboboxModelsShow> Valores = new BindingList<EstadosEntityComboboxModelsShow>();
                public override BindingList<EstadosEntityComboboxModelsShow> GetBindingList() {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Estados_RP.Select(x => new EstadosEntityComboboxModelsShow {
                                                Estado_Nombre = x.Estado,
                                                Estado_Id = x.ID_Estado_RP
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
                        } catch (Exception ex)
                        {
                                // Manejo de excepciones
                                Console.WriteLine("Error: " + ex.Message);
                        }

                        return null;
                }
        }
}
