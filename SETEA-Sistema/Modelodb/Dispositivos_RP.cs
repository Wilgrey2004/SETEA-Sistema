//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SETEA_Sistema.Modelodb
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dispositivos_RP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dispositivos_RP()
        {
            this.Reparaciones_RP = new HashSet<Reparaciones_RP>();
        }
    
        public int ID_Dispositivo_RP { get; set; }
        public string Fallo_Encontrado_Del_Dispositivo { get; set; }
        public string Descripcion_Del_Problema_De_Parte_Del_Cliente { get; set; }
        public Nullable<int> Info_Dispositivo_ID { get; set; }
        public Nullable<System.DateTime> Fecha_Recepcion { get; set; }
    
        public virtual Dispositivo_Info_RP Dispositivo_Info_RP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reparaciones_RP> Reparaciones_RP { get; set; }
    }
}
