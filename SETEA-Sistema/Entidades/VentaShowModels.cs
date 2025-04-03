using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Entidades
{
        public class VentaShowModels
        {
                public int ID_Venta { get; set; }
                public string Nombre_Cliente { get; set; }
                public string Tel_Cliente { get; set; }
                public string Nombre_Producto { get; set; }
                public string Codigo_Producto { get; set; }
                public int ID_Producto { get; set; }
                public int? Cantidad_Producto { get; set; }
                public decimal? Precio_Producto_Unidad { get; set; }
                public decimal?  Precio_Por_Cantidad { get; set; }
                public int? Deescuento { get; set; }
                public DateTime? Fecha_Venta { get; set; }

        }
}
