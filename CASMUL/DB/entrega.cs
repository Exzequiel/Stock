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
    
    public partial class entrega
    {
        public int id_entrega { get; set; }
        public string nro_entrega { get; set; }
        public System.DateTime fecha_transaccion { get; set; }
        public Nullable<int> id_item { get; set; }
        public Nullable<int> id_cable { get; set; }
        public int cant_aentregar { get; set; }
        public bool confirmado { get; set; }
        public int semana { get; set; }
        public int periodo { get; set; }
    
        public virtual cable cable { get; set; }
        public virtual item item { get; set; }
    }
}
