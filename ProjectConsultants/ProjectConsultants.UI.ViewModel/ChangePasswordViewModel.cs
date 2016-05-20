using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConsultants.UI.ViewModel
{
    public class ChangePasswordViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email Id")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password")]
        [DataType(DataType.Password)]
        [StringLength(18, ErrorMessage = "The password must be atleast 8 characters long", MinimumLength = 8)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [StringLength(18, ErrorMessage = "The password must be atleast 8 characters long", MinimumLength = 8)]
        public string NewPassword { get; set; }
    }
}   

