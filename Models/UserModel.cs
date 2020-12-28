using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppAPI.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="First Name is Required.")]
        [Display(Name ="First Name :")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name :")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is Required.")]
        public string Lastname { get; set; }
        [Display(Name = "Email:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Name is Required.")]
        public string Email { get; set; }
        [Display(Name = "Password:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Name is Required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm Password :")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ConfirmPassword Name is Required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password and Confirm Password Should be Same.")]
        public string ConfirmPassword { get; set; }
        public DateTime CreatedOn { get; set; }
        public string SuccessMessage { get; set; }

    }
}