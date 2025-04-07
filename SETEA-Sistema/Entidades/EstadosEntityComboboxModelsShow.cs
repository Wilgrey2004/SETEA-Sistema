using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Entidades
{
        internal class EstadosEntityComboboxModelsShow
        {
                public int Estado_Id { get; set; }
                public string Estado_Nombre { get; set; }

                public override string ToString() {
                        return Estado_Nombre;
                }
        }
}
