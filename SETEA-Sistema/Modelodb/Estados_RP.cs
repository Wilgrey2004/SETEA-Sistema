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
    
    public partial class Estados_RP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estados_RP()
        {
            this.Reparaciones_RP = new HashSet<Reparaciones_RP>();
        }
    
        public int ID_Estado_RP { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> Fecha_Creacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reparaciones_RP> Reparaciones_RP { get; set; }
    }
}
