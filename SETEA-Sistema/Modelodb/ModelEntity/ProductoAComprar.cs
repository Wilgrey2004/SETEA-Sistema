using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Modelodb.ModelEntity
{
        public class ProductoAComprar
        {
                private static int Count = 0;
                public int id { get; set; }
                public string Nombre { get; set; }
                public decimal CantidadAComprar { get; set; }
                public decimal PrecioDeUnidad { get; set; }

               
                public ProductoAComprar() {
                        Count++;
                        id = Count;
                       
                }
        }
}
