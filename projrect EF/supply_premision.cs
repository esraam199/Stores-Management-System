//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projrect_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class supply_premision
    {
        public int supplier_id { get; set; }
        public int store_id { get; set; }
        public string item_id { get; set; }
        public int premmission_no { get; set; }
        public Nullable<System.DateTime> production_date { get; set; }
        public Nullable<System.DateTime> premmision_date { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<System.DateTime> expire_date { get; set; }
    
        public virtual item1 item1 { get; set; }
        public virtual store store { get; set; }
        public virtual supplier supplier { get; set; }
    }
}
