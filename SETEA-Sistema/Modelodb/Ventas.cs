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
    
    public partial class Ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ventas()
        {
            this.DetallesVenta = new HashSet<DetallesVenta>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public System.DateTime Fecha { get; set; }
        public int MetodoPagoId { get; set; }
        public decimal Total { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesVenta> DetallesVenta { get; set; }
        public virtual MetodosPago MetodosPago { get; set; }
    }
}
