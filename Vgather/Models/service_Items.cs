//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vgather.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class service_Items
    {
        public string service_items1 { get; set; }
        public string Service_Company_ID { get; set; }
        public string items { get; set; }
        public int service_item_id { get; set; }
    
        public virtual service_company service_company { get; set; }
    }
}
