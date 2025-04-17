using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Entidades
{
        public class UsuarioShowModels
        {
                public int Id_Usuario { get; set; }
                public string Nombre { get; set; }
                public string Correo { get; set; }
                public string Contraseña { get; set; }
                public string Rol_Nombre { get; set; }
                public DateTime? fecha_creacion { get; set; }
                public DateTime? ultima_vez { get; set; }
        }
}
