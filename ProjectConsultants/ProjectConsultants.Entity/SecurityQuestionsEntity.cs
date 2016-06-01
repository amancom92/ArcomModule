using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectConsultants.Entity
{
    [Table("[SecurityQuestions]")]
    public class SecurityQuestionsEntity
    {
        /// <summary>
        /// Gets or sets the question identifier.
        /// </summary>
        /// <value>
        /// The question identifier.
        /// </value>
        [Key]
        public int QuestionId { get; set; }
        /// <summary>
        /// Gets or sets the name of the question.
        /// </summary>
        /// <value>
        /// The name of the question.
        /// </value>
        [Required]
        public string QuestionName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool IsActive { get; set; }
        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>
        /// The created by.
        /// </value>
        [Required]
        public int CreatedBy { get; set; }
        /// <summary>
        /// Gets or sets the created on.
        /// </summary>
        /// <value>
        /// The created on.
        /// </value>
        [Required]
        public DateTime CreatedOn { get; set; }

    }
}
