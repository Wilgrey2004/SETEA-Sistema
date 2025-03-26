using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Entidades
{
    class ProductoShowModels
    {
        public int IdProducto { get; set; }
        public string NombreProductp { get; set; }
        public int? CantidadRestante { get; set; }
        public decimal? PrecioUnidad { get; set; }
    }
}
