﻿using System.ComponentModel.DataAnnotations;

namespace ProjectConsultants.UI.ViewModel
{
    public  class LoginViewModel: BaseViewModel
    {
        [Key]
        public int UserId { get; set; }
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
        [StringLength(8,ErrorMessage ="Password length must be between 4 to 8",MinimumLength =4)]
        //[RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{4,8}$",ErrorMessage = "Password expresion that requires one lower case letter, one upper case letter, one digit, 4-8 length, and no spaces.")]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }      

    }
}
