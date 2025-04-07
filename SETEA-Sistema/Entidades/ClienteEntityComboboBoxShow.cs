using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Entidades
{
        internal class ClienteEntityComboboBoxShow
        {
                public int Cliente_ID { get; set; }
                public string Nombre_Del_Cliente { get; set; }
                public string Correo_Del_Cliente { get; set; }

                public override string ToString()
                {
                        return $"{Nombre_Del_Cliente} / {Correo_Del_Cliente}";
                }
        }
}
