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
    
    public partial class address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public address()
        {
            this.orders = new HashSet<order>();
        }
    
        public decimal id { get; set; }
        public string address1 { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public short active { get; set; }
        public decimal user_id { get; set; }
        public string apartment { get; set; }
        public string intercom { get; set; }
        public string floor { get; set; }
        public string entry { get; set; }
    
        public virtual user user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
    }
}
