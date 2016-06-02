﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ProjectConsultants.UI.ViewModel
{
    public class RegisterViewModel : BaseViewModel
    {
        [Key]
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [Required]     
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [Required]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required]
        [Remote("EmailDbValidation", "User", ErrorMessage = "Email address already registered.")]
        [EmailAddress]
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "password and confirm password are not same")]
        public string ConfirmPassword { get; set; } 
        [Required]
        //[RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{4,8}$",ErrorMessage = "Password expresion that requires one lower case letter, one upper case letter, one digit, 4-8 length, and no spaces.")]
        public string SecurityQuestionAnswer { get; set; }
        public int SecurityQuestionId { get; set; }
        public List<SelectListItem> SecurityQuestionList { get; set; }

    }
}
