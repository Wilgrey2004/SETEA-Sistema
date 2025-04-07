using System;

namespace SETEA_Sistema.Entidades
{
        public class ReparacionesRPShowModels
        {
                public int ID_Reparacion { get; set; }
                public string Nombre_Cliente { get; set; }
                public string Correo_Del_Cliente { get; set; }
                public string Estado { get; set; }
                public string Diagnostico_Inicial { get; set; }
                public string Fallo_Detectado { get; set; }
                public string Marca_Dispositivo { get; set; }
                public string Tipo_Dispositivo { get; set; }
                public DateTime? Fecha_Ingreso { get; set; }
                public DateTime? Fecha_Alta { get; set; }
                public decimal? Cobro_Reparacion { get; set; }
        }
}
