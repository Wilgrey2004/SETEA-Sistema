using SETEA_Sistema.Entidades;
using SETEA_Sistema.Interfaces;
using SETEA_Sistema.Modelodb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Utilidades.ReturnsBindingList
{
        internal class GetBindingListReparacionesRP : GenericReturnBinlingList<ReparacionesRPShowModels>
        {
                public override BindingList<ReparacionesRPShowModels> GetBindingList() {
                        BindingList<ReparacionesRPShowModels> valores = new BindingList<ReparacionesRPShowModels>();

                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                var query = db.Reparaciones_RP
                                    .Include(r => r.Cliente_RP)
                                    .Include(r => r.Estados_RP)
                                    .Include(r => r.Dispositivos_RP.Dispositivo_Info_RP.Marca_Del_Dispositivo_RP)
                                    .Include(r => r.Dispositivos_RP.Dispositivo_Info_RP.Tipo_Dispositivos_RP)
                                    .Include(r => r.Dispositivos_RP.Fallo_Encontrado_Del_Dispositivo)
                                    .Select(r => new ReparacionesRPShowModels {
                                            ID_Reparacion = r.ID_Reparacion_RP,
                                            Nombre_Cliente = r.Cliente_RP.Nombre_Cliente_RP,
                                            Correo_Del_Cliente = r.Cliente_RP.Correo_Electronico_Cliente_RP,
                                            Estado = r.Estados_RP.Estado,
                                            Diagnostico_Inicial = r.Diagnostico_Inicial,
                                            Fallo_Detectado = r.Dispositivos_RP.Fallo_Encontrado_Del_Dispositivo,
                                            Marca_Dispositivo = r.Dispositivos_RP.Dispositivo_Info_RP.Marca_Del_Dispositivo_RP.Nombre_De_La_Marca,
                                            Tipo_Dispositivo = r.Dispositivos_RP.Dispositivo_Info_RP.Tipo_Dispositivos_RP.Nombre_Tipo,
                                            Fecha_Ingreso = r.Fecha_De_Ingreso,
                                            Fecha_Alta = r.Fecha_De_Alta,
                                            Cobro_Reparacion = r.Cobro_Reparacion
                                    }).ToList();

                                if (query != null)
                                {
                                        valores = new BindingList<ReparacionesRPShowModels>(query);
                                        return valores;
                                }
                        }

                        return null;
                }

                public Reparaciones_RP FindById( int id ) {
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                return db.Reparaciones_RP.FirstOrDefault(r => r.ID_Reparacion_RP == id);
                        }
                }

                public bool DeleteById( int id ) {
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                var reparacion = db.Reparaciones_RP.Find(id);
                                if (reparacion != null)
                                {
                                        db.Reparaciones_RP.Remove(reparacion);
                                        db.SaveChanges();
                                        return true;
                                }
                                return false;
                        }
                }



               
        }
}

