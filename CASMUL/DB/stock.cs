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
    
    public partial class stock
    {
        public int id_stock { get; set; }
        public Nullable<int> id_item { get; set; }
        public Nullable<int> id_categoria { get; set; }
        public Nullable<int> id_unidad_medida { get; set; }
        public Nullable<int> id_finca { get; set; }
        public Nullable<short> cant_stock { get; set; }
        public Nullable<int> semana { get; set; }
        public Nullable<int> periodo { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public Nullable<System.DateTime> fecha_modificado { get; set; }
        public string modificado_por { get; set; }
    
        public virtual item item { get; set; }
    }
}