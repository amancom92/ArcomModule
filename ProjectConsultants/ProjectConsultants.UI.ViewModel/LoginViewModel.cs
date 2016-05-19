using System.ComponentModel.DataAnnotations;

namespace ProjectConsultants.UI.ViewModel
{
    public  class LoginViewModel
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
        public string Password { get; set; }

    }
}
