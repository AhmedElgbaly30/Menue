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
    
    public partial class extra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public extra()
        {
            this.variants_has_extras = new HashSet<variants_has_extras>();
        }
    
        public decimal id { get; set; }
        public decimal item_id { get; set; }
        public decimal price { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
        public int extra_for_all_variants { get; set; }
    
        public virtual item item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<variants_has_extras> variants_has_extras { get; set; }
    }
}
