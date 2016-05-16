using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace ProjectConsultants.UI.ViewModel
{
    public class ProjectInformationViewModel
    {
        /// <summary>
        /// Gets or sets the project identifier.
        /// </summary>
        /// <value>
        /// The project identifier.
        /// </value>
        [Required]
        public int ProjectId { get; set; }
        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        /// <value>
        /// The name of the project.
        /// </value>
        [Required]
        [StringLength(50)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or sets the project address1.
        /// </summary>
        /// <value>
        /// The project address1.
        /// </value>
        [Required]
        public string ProjectAddress1 { get; set; }
        /// <summary>
        /// Gets or sets the project address2.
        /// </summary>
        /// <value>
        /// The project address2.
        /// </value>
        [Required]
        public string ProjectAddress2 { get; set; }
        /// <summary>
        /// Gets or sets the project city.
        /// </summary>
        /// <value>
        /// The project city.
        /// </value>
        [Required]
        [StringLength(30)]
        public string ProjectCity { get; set; }

        /// <summary>
        /// Gets or sets the project postal code.
        /// </summary>
        /// <value>
        /// The project postal code.
        /// </value>
        [Required]
        //This will match US postal codes (zip codes) using simple 5 digit format with optional 4 digit extension seperated by a space or hyphen. Will not accept letters. 
        [RegularExpression(@"^[0-9]{5}([0-9]{4})?$", ErrorMessage = "US Postal Code Only.Example[567894444]")]
        public int ProjectPostalCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the owner.
        /// </summary>
        /// <value>
        /// The name of the owner.
        /// </value>
        [Required]
        [StringLength(40)]
        public string OwnerName { get; set; }
        /// <summary>
        /// Gets or sets the owner address1.
        /// </summary>
        /// <value>
        /// The owner address1.
        /// </value>
        [Required]
        public string OwnerAddress1 { get; set; }
        /// <summary>
        /// Gets or sets the owner address2.
        /// </summary>
        /// <value>
        /// The owner address2.
        /// </value>
        [Required]
        public string OwnerAddress2 { get; set; }
        /// <summary>
        /// Gets or sets the owner city.
        /// </summary>
        /// <value>
        /// The owner city.
        /// </value>
        [Required]
        public string OwnerCity { get; set; }

        /// <summary>
        /// Gets or sets the owner postal code.
        /// </summary>
        /// <value>
        /// The owner postal code.
        /// </value>
        [Required]
        //This will match US postal codes (zip codes) using simple 5 digit format with optional 4 digit extention seperated by a space or hyphen. Will not accept letters.
        [RegularExpression(@"^[0-9]{5}([0-9]{4})?$", ErrorMessage = "US Postal Code Only.Example[567894444]")]
        public int OwnerPostalCode { get; set; }

        /// <summary>
        /// Gets or sets the owner representative.
        /// </summary>
        /// <value>
        /// The owner representative.
        /// </value>
        [Required]
        public string OwnerRepresentative { get; set; }
        /// <summary>
        /// Gets or sets the owner email address.
        /// </summary>
        /// <value>
        /// The owner email address.
        /// </value>
        [Required]
        [EmailAddress]
        public string OwnerEmailAddress { get; set; }
        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        [Required]
        //US Phone number that accept a dot, a space, a dash, a forward slash, between the numbers. Will Accept a 1 or 0 in front. Area Code not necessary.
       // [RegularExpression(@"((\(\d{3}\)?)|(\d{3}))([\s-./]?)(\d{3})([\s-./]?)(\d{4})", ErrorMessage = "US Phone number that accept a dot, a space, a dash, a forward slash, between the numbers. Will Accept a 1 or 0 in front. Area Code not necessary.")]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>
        /// The mobile number.
        /// </value>
        [Required]
        //US Phone number that accept a dot, a space, a dash, a forward slash, between the numbers. Will Accept a 1 or 0 in front. Area Code not necessary.
       // [RegularExpression(@"((\(\d{3}\)?)|(\d{3}))([\s-./]?)(\d{3})([\s-./]?)(\d{4})", ErrorMessage = "US Phone number that accept a dot, a space, a dash, a forward slash, between the numbers. Will Accept a 1 or 0 in front. Area Code not necessary.")]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets the state of the owner.
        /// </summary>
        /// <value>
        /// The state of the owner.
        /// </value>
        public int OwnerStateId { get; set; }
        /// <summary>
        /// Gets or sets the owner state list.
        /// </summary>
        /// <value>
        /// The owner state list.
        /// </value>
        public IEnumerable<SelectListItem> OwnerStateList { get; set; }

        /// <summary>
        /// Gets or sets the owner country identifier.
        /// </summary>
        /// <value>
        /// The owner country identifier.
        /// </value>
        public int OwnerCountryId { get; set; }
        /// <summary>
        /// Gets or sets the owner country list.
        /// </summary>
        /// <value>
        /// The owner country list.
        /// </value>
        public IEnumerable<SelectListItem> OwnerCountryList { get; set; }

        /// <summary>
        /// Gets or sets the procurement type identifier.
        /// </summary>
        /// <value>
        /// The procurement type identifier.
        /// </value>
        public int ProcurementTypeId { get; set; }
        /// <summary>
        /// Gets or sets the procurement type list.
        /// </summary>
        /// <value>
        /// The procurement type list.
        /// </value>
        public IEnumerable<SelectListItem> ProcurementTypeList { get; set; }

        /// <summary>
        /// Gets or sets the contract type identifier.
        /// </summary>
        /// <value>
        /// The contract type identifier.
        /// </value>
        public int ContractTypeId { get; set; }
        /// <summary>
        /// Gets or sets the contract type list.
        /// </summary>
        /// <value>
        /// The contract type list.
        /// </value>
        public IEnumerable<SelectListItem> ContractTypeList { get; set; }

        /// <summary>
        /// Gets or sets the contract origin identifier.
        /// </summary>
        /// <value>
        /// The contract origin identifier.
        /// </value>
        public int ContractOriginId { get; set; }
        /// <summary>
        /// Gets or sets the contract origin list.
        /// </summary>
        /// <value>
        /// The contract origin list.
        /// </value>
        public IEnumerable<SelectListItem> ContractOriginList { get; set; }

        /// <summary>
        /// Gets or sets the project state identifier.
        /// </summary>
        /// <value>
        /// The project state identifier.
        /// </value>
        public int ProjectStateId { get; set; }
        /// <summary>
        /// Gets or sets the project state list.
        /// </summary>
        /// <value>
        /// The project state list.
        /// </value>
        public IEnumerable<SelectListItem> ProjectStateList { get; set; }

        /// <summary>
        /// Gets or sets the project country identifier.
        /// </summary>
        /// <value>
        /// The project country identifier.
        /// </value>
        public int ProjectCountryId { get; set; }
        /// <summary>
        /// Gets or sets the project country list.
        /// </summary>
        /// <value>
        /// The project country list.
        /// </value>
        public IEnumerable<SelectListItem> ProjectCountryList { get; set; }
    }

}


