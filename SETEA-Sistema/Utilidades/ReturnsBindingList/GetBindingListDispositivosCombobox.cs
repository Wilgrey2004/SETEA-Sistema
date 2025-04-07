using SETEA_Sistema.Entidades;
using SETEA_Sistema.Interfaces;
using SETEA_Sistema.Modelodb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace SETEA_Sistema.Utilidades.ReturnsBindingList
{
        internal class GetBindingListDispositivosCombobox : GenericReturnBinlingList<DispositivosComboboxShowModels>
        {
                BindingList<DispositivosComboboxShowModels> Valores = new BindingList<DispositivosComboboxShowModels>();

                public override BindingList<DispositivosComboboxShowModels> GetBindingList() {
                        try
                        {
                                using (SeteaEntities1 db = new SeteaEntities1())
                                {
                                        var query = db.Dispositivos_RP
                                            .Include(x => x.Dispositivo_Info_RP.Marca_Del_Dispositivo_RP)
                                            .Include(x => x.Dispositivo_Info_RP.Tipo_Dispositivos_RP)
                                            .Select(x => new DispositivosComboboxShowModels {
                                                    Dispositivo_ID = x.ID_Dispositivo_RP,
                                                    Tipo_Dispositivo = x.Dispositivo_Info_RP.Tipo_Dispositivos_RP.Nombre_Tipo,
                                                    Marca_Del_Dispositivo = x.Dispositivo_Info_RP.Marca_Del_Dispositivo_RP.Nombre_De_La_Marca,
                                                    Diagnostico_Del_Dispositivo = x.Fallo_Encontrado_Del_Dispositivo
                                            })
                                            .ToList();

                                        Valores.Clear();
                                        foreach (var item in query)
                                        {
                                                Valores.Add(item);
                                        }

                                        return Valores;
                                }
                        } catch (Exception ex)
                        {
                                Console.WriteLine("Error: " + ex.Message);
                        }

                        return null;
                }
        }
}