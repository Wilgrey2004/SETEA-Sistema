using MigraDoc.DocumentObjectModel.Internals;
using SETEA_Sistema.Entidades;
using SETEA_Sistema.Interfaces;
using SETEA_Sistema.Modelodb;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace SETEA_Sistema.Utilidades.ReturnsBindingList
{
        public class GetBindingListProductoShowsModels : GenericReturnBinlingList<ProductoReporteModelShows>
        {
                public override BindingList<ProductoReporteModelShows> GetBindingList() {

                        BindingList<ProductoReporteModelShows> valores = new BindingList<ProductoReporteModelShows>();
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                var query = db.producto.Include(x => x.Categorias)
                                        .Include(x => x.estado1)
                                        .Where(x => x.cantidadRestante > 0)
                                        .Select(x => new ProductoReporteModelShows {
                                                ID_Producto = x.idProducto,
                                                Nombre_Del_Producto = x.nombre,
                                                Descripcion_Del_Producto = x.descripcion,
                                                Nombre_Categoria = x.Categorias.Nombre,
                                                Estado = x.estado1.Estado1,
                                                Precio_Unidad = x.PrecioUnidad,
                                                Cantidad_Restante = x.cantidadRestante,
                                                Fecha_Creacion = x.FechaCreacion
                                        }).ToList();
                               
                                if (query != null)
                                {
                                        valores = new BindingList<ProductoReporteModelShows>(query);
                                        return valores;
                                }

                        }
                        return null;
                }

                public BindingList<ProductoReporteModelShows> GetBindingListProductosPorCantidad(int cantidad) {
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                BindingList<ProductoReporteModelShows> valores = new BindingList<ProductoReporteModelShows>();

                                var query = db.producto.Include(x => x.Categorias)
                                                .Include(x => x.estado1)
                                                .Where(x => x.cantidadRestante == cantidad)
                                                .Select(x => new ProductoReporteModelShows {
                                                        ID_Producto = x.idProducto,
                                                        Nombre_Del_Producto = x.nombre,
                                                        Descripcion_Del_Producto = x.descripcion,
                                                        Nombre_Categoria = x.Categorias.Nombre,
                                                        Estado = x.estado1.Estado1,
                                                        Precio_Unidad = x.PrecioUnidad,
                                                        Cantidad_Restante = x.cantidadRestante,
                                                        Fecha_Creacion = x.FechaCreacion
                                                }).ToList();

                                if (query != null)
                                {
                                        valores = new BindingList<ProductoReporteModelShows>(query);
                                        return valores;
                                }
                        }
                        return null;
                }
        }
}
