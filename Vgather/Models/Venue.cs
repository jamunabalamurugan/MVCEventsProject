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
    
    public partial class Venue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venue()
        {
            this.EventBookings = new HashSet<EventBooking>();
        }
    
        public int Venue_ID { get; set; }
        public string Venue_Name { get; set; }
        public string Capacity { get; set; }
        public string Budget { get; set; }
        public string Venue_Type { get; set; }
        public string Availability_Status { get; set; }
        public string EventTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventBooking> EventBookings { get; set; }
        public virtual EventType EventType { get; set; }
    }
}
