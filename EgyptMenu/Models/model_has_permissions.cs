//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EgyptMenu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class model_has_permissions
    {
        public long permission_id { get; set; }
        public string model_type { get; set; }
        public decimal model_id { get; set; }
    
        public virtual permission permission { get; set; }
    }
}