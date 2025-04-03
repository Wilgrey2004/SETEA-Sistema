using SETEA_Sistema.Entidades;
using SETEA_Sistema.Interfaces;
using SETEA_Sistema.Modelodb;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Utilidades.ReturnsBindingList
{
        internal class GetBindingListcodigosShowModels : GenericReturnBinlingList<CodigosDeproductosShowsModels>
        {
                public override BindingList<CodigosDeproductosShowsModels> GetBindingList() {
                        BindingList<CodigosDeproductosShowsModels> valores = new BindingList<CodigosDeproductosShowsModels>();
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                var query = db.Codigo_De_Productos
                                        .Include(x => x.producto)
                                        .Where(x => x.Estado_Codigo == "Activo")
                                        .Select(
                                        x => new CodigosDeproductosShowsModels {
                                                ID_Del_Codigo = x.ID,
                                                ID_Producto = x.ID_Producto_Enlazado,
                                                Nombre_Del_Producto = x.producto.nombre,
                                                Codigo_Del_Producto = x.CodigoDelProducto,
                                                Cantidad_Restante = x.producto.cantidadRestante,
                                                Precio_Del_Producto = x.producto.PrecioUnidad,
                                                Fecha_De_Creacion = (DateTime)x.Fecha_De_Agregacion
                                        }).ToList();

                                if (query != null)
                                {
                                        valores = new BindingList<CodigosDeproductosShowsModels>(query);
                                        return valores;
                                }
                        }
                        return null;
                }
        }
}
