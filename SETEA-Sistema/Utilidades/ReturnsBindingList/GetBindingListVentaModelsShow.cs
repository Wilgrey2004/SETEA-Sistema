using SETEA_Sistema.Entidades;
using SETEA_Sistema.Interfaces;
using SETEA_Sistema.Modelodb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SETEA_Sistema.Utilidades.ReturnsBindingList
{
        internal class GetBindingListVentaModelsShow : GenericReturnBinlingList<VentaShowModels>
        {
                // Método auxiliar que centraliza la conversión.
                private BindingList<VentaShowModels> ConversorDeLista( IEnumerable<VentaEnCaja> lista ) {
                        var converted = lista.Select(x => new VentaShowModels {
                                ID_Venta = x.id,
                                Nombre_Cliente = x.Nombre_cliente,
                                Tel_Cliente = x.NumeroDelCliente,
                                Nombre_Producto = x.producto.nombre,
                                Codigo_Producto = x.codigoDelProducto,
                                ID_Producto = x.producto.idProducto,
                                Cantidad_Producto = x.cantidadProducto,
                                Precio_Producto_Unidad = x.producto.PrecioUnidad,
                                Precio_Por_Cantidad = x.precioPorCantidad,
                                Deescuento = x.Descuento,
                                Fecha_Venta = x.FechaVenta
                        }).ToList();
                        return new BindingList<VentaShowModels>(converted);
                }

                public override BindingList<VentaShowModels> GetBindingList() {
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                var lista = db.VentaEnCaja.Include(x => x.producto).ToList();
                                return ConversorDeLista(lista);
                        }
                }

                public BindingList<VentaShowModels> GetBindingListApartirDeOtra( BindingList<VentaEnCaja> listaAConvertir ) {
                        return ConversorDeLista(listaAConvertir);
                }

                public BindingList<VentaShowModels> GetListConLaFecha( DateTime? fecha ) {
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                var lista = db.VentaEnCaja
                                    .Include(x => x.producto)
                                    .Where(v => DbFunctions.TruncateTime(v.FechaVenta) == fecha)
                                    .ToList();
                                if (!lista.Any())
                                {
                                        MessageBox.Show("No se encontraron productos con la fecha proporcionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return null;
                                }
                                return ConversorDeLista(lista);
                        }
                }

                public BindingList<VentaShowModels> GetListPorNombreOCodigo( string NombreOCodigo ) {
                        using (SeteaEntities1 db = new SeteaEntities1())
                        {
                                var lista = db.VentaEnCaja
                                    .Include(x => x.producto)
                                    .Where(v => v.producto.nombre.Contains(NombreOCodigo) || v.codigoDelProducto.Contains(NombreOCodigo))
                                    .ToList();
                                if (!lista.Any())
                                {
                                        MessageBox.Show("No se encontraron ventas con el nombre o código proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return null;
                                }
                                return ConversorDeLista(lista);
                        }
                }
        }
}

