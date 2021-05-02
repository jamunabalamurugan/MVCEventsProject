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
    using System.ComponentModel.DataAnnotations;

    public partial class Payment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payment()
        {
            this.EventBookings = new HashSet<EventBooking>();
        }
    
        public string Payment_Status { get; set; }
        [CreditCard]
        [Required(ErrorMessage ="Please enter Card Number")] 
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "please enter Amount")]
        [DataType(DataType.Currency)]
        public Nullable<decimal> Amount { get; set; }
        public int PaymentID { get; set; }
        public string payment_Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventBooking> EventBookings { get; set; }
    }
}