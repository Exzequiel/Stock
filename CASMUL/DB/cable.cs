//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CASMUL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class cable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cable()
        {
            this.entrega = new HashSet<entrega>();
        }
    
        public int id_cable { get; set; }
        public Nullable<int> id_grupo { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public string descripcion { get; set; }
        public Nullable<decimal> hectaria { get; set; }
        public Nullable<decimal> acres { get; set; }
        public Nullable<bool> activo { get; set; }
    
        public virtual grupo grupo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entrega> entrega { get; set; }
    }
}
