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
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Service
    {
        [Required(ErrorMessage = "Please Enter your company Name")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z ]{3,20}$", ErrorMessage = "Invalid Company Name")]
        [Display(Name = "Company Name")]
        public string Company_Name { get; set; }

        [Required(ErrorMessage = "Please Enter Description")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z ]{3,20}$", ErrorMessage = "Invalid Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please Enter Type")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z ]{3,20}$", ErrorMessage = "Invalid Type")]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Please Enter your EmailId")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Email ID")]
        public string Contact_Email { get; set; }

        [Required(ErrorMessage = "Please Enter your Address")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z ]{3,20}$", ErrorMessage = "Invalid Address")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression("^[789][0-9]{9}$", ErrorMessage = "Enter Valid Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please Enter Valid Phone Number")]
        public string Phone_no { get; set; }

        [ValidateFile(ErrorMessage = "Please select a PNG image smaller than 1MB")]
        [Display(Name = "Certification")]
        public string Certification { get; set; }

        [Required(ErrorMessage = "Please Enter your serviceID ")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z ]{3,20}$", ErrorMessage = "Invalid serviceID")]
        [Display(Name = "Service ID")]
        public int serviceID { get; set; }
    }
}
