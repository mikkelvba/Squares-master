//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Squares.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class Admin
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Username")]
        //[Remote("UniqueAdminName", "Tools", ErrorMessage = "Username is already taken")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Your username must be at least 5 characters")]
        //[Required(ErrorMessage = "You forgot to enter a username")]
        public string username { get; set; }

        [Display(Name = "Name")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Your name must be at least 2 characters")]
        //[Required(ErrorMessage = "You forgot to enter your name")]
        public string fullName { get; set; }

        [Display(Name = "Email")]
        //[Remote("UniqueAdminEmail", "Tools", ErrorMessage = "Email is already taken")]
        [RegularExpression(@"\S+@(\S+\.)+\w{2,4}", ErrorMessage = "There is a problem with the email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You forgot to enter your email")]
        public string email { get; set; }

        [Display(Name = "Password")]
        [RegularExpression(@"^(?=.*\d).{4,20}$", ErrorMessage = "Password must be between 4 and 20 digits long and include at least one numeric digit.")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You forgot to enter your password")]
        public string password { get; set; }

        public Nullable<System.DateTime> signupDate { get; set; }
    }
}