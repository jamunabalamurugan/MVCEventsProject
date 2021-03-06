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
   

    public partial class Participant
    {
        public Nullable<int> Registration_ID { get; set; }
        public Nullable<int> Event_ID { get; set; }
        [Required(ErrorMessage = "Please enter the EventName")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z ]{3,20}$", ErrorMessage = "Invalid EventName")]
        [Display(Name = "EventName")]

        public string EventName { get; set; }

        [Required(ErrorMessage = "Please enter the CompanyName")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z ]{3,20}$", ErrorMessage = "Invalid CompanyName")]
        [Display(Name = "CompanyName")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter your EmailID")]
        [DataType(DataType.Text)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "EmailID")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Contact Number")]
        [DataType(DataType.Text)]
        [RegularExpression("^[789][0-9]{9}$", ErrorMessage = "Enter Valid Contact Number")]
        [Display(Name = "Contact Number")]
        public string Contactnumber { get; set; }

        [Required(ErrorMessage = "Please enter your Name")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z ]{3,20}$", ErrorMessage = "Invalid Participant Name")]
        [Display(Name = "participantName")]
        public string participantName { get; set; }

        [Required(ErrorMessage = "Please enter participantsPaymentID")]
        [Display(Name = "participantsPaymentID")]
        public int participantsPaymentID { get; set; }
    
        public virtual EventBooking EventBooking { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
