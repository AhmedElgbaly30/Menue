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
    
    public partial class order_has_items
    {
        public decimal id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public decimal order_id { get; set; }
        public decimal item_id { get; set; }
        public int qty { get; set; }
        public string extras { get; set; }
        public Nullable<decimal> vat { get; set; }
        public Nullable<decimal> vatvalue { get; set; }
        public Nullable<decimal> variant_price { get; set; }
        public string variant_name { get; set; }
    
        public virtual item item { get; set; }
        public virtual order order { get; set; }
    }
}