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
    
    public partial class usuario
    {
        public int id_usuario { get; set; }
        public string IdAspnetUser { get; set; }
        public Nullable<int> id_tipo_usuario { get; set; }
        public Nullable<int> id_finca { get; set; }
        public string identidad { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cuenta_usuario { get; set; }
        public System.DateTime fecha_nacimiento { get; set; }
        public string nro_telefono { get; set; }
        public string email { get; set; }
        public bool activo { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual finca finca { get; set; }
        public virtual tipo_usuario tipo_usuario { get; set; }
    }
}
