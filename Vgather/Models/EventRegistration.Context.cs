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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EventManagementEntities1 : DbContext
    {
        public EventManagementEntities1()
            : base("name=EventManagementEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EventBooking> EventBookings { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<payment_Booking> payment_Booking { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<service_company> service_company { get; set; }
        public virtual DbSet<service_Items> service_Items { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<serviceType> serviceTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }
    }
}
