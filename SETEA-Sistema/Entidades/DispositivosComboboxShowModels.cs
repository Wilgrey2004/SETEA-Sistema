using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Entidades
{
        internal class DispositivosComboboxShowModels
        {
                public int Dispositivo_ID { get; set; }
                public string Tipo_Dispositivo { get; set; }
                public string Marca_Del_Dispositivo { get; set; }
                public string Diagnostico_Del_Dispositivo { get; set; }

                public override string ToString() {
                        return $"{Tipo_Dispositivo} / {Marca_Del_Dispositivo} / {Diagnostico_Del_Dispositivo}";
                }
        }
}
