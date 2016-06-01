using System.ComponentModel.DataAnnotations;

namespace ProjectConsultants.UI.ViewModel
{
    public class ChangePasswordViewModel: BaseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email Id")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password")]       
        [DataType(DataType.Password)]        
        [StringLength(18, ErrorMessage = "The password must be atleast 5 characters long", MinimumLength = 5)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please Enter Your New Password")]
        [DataType(DataType.Password)]
        [StringLength(18, ErrorMessage = "The password must be atleast 5 characters long", MinimumLength = 5)]
        public string NewPassword { get; set; }
    }
}   

