using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Entidades
{
    class CodigosDeproductosShowsModels
    {
        public int? ID_Del_Codigo { get; set; }
        public int? ID_Producto { get; set; }
        public string Nombre_Del_Producto { get; set; }
        public string Codigo_Del_Producto { get; set; }
        public int? Cantidad_Restante { get; set; }
        public decimal? Precio_Del_Producto { get; set; }
        public DateTime Fecha_De_Creacion { get; set; }

         
    }
}
