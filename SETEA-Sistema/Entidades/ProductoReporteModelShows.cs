using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Entidades
{
        public class ProductoReporteModelShows
        {
                public int ID_Producto { get; set; }
                public string Nombre_Del_Producto { get; set; }
                public string Descripcion_Del_Producto { get; set; }
                public int? Cantidad_Restante { get; set; }
                public decimal? Precio_Unidad { get; set; }
                public string Nombre_Categoria { get; set; }
                public string Estado { get; set; }
                public DateTime? Fecha_Creacion { get; set; }

        }
}
