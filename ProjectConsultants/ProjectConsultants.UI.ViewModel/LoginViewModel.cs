using System.ComponentModel.DataAnnotations;

namespace ProjectConsultants.UI.ViewModel
{
    public  class LoginViewModel: BaseViewModel
    {
        //[Key]
        //public int Id { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required]
        [EmailAddress]
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20,ErrorMessage ="Password length must be between 4 to 20",MinimumLength =4)]
        public string Password { get; set; }

    }
}
