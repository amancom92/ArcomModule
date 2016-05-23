using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ProjectConsultants.UI.ViewModel
{
   public class RegistrationViewModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Remote("EmailExists", "Registration", HttpMethod = "POST", ErrorMessage = "Email address already registered.")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    
    [System.ComponentModel.DataAnnotations.Compare("Password",ErrorMessage ="password and confirm password are not same")]
        public string ConfirmPassword { get; set; }
    }
}
