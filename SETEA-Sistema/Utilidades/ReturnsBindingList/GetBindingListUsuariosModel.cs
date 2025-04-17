using System;
using System.ComponentModel;
using System.Linq;
using System.Data.Entity;
using SETEA_Sistema.Interfaces;
using SETEA_Sistema.Modelodb;
using SETEA_Sistema.Entidades;

internal class GetBindingListUsuariosModel : GenericReturnBinlingList<UsuarioShowModels>
{
        public override BindingList<UsuarioShowModels> GetBindingList() {
                BindingList<UsuarioShowModels> valores = new BindingList<UsuarioShowModels>();
                using (SeteaEntities1 db = new SeteaEntities1())
                {
                        var query = db.Usuarios
                            .Include(x => x.Roles) // Solo si necesitas info del rol
                            .Select(x => new UsuarioShowModels {
                                    Id_Usuario = x.Id,
                                    Nombre = x.Nombre,
                                    Correo = x.Correo,
                                    Contraseña = x.Contraseña,
                                    Rol_Nombre = x.Roles.Nombre,
                                    fecha_creacion = x.FechaCreacion,
                                    ultima_vez = x.Ultima_Vez
                            })
                            .ToList();

                        if (query != null)
                        {
                                valores = new BindingList<UsuarioShowModels>(query);
                                return valores;
                        }
                }

                return null;
        }
}
