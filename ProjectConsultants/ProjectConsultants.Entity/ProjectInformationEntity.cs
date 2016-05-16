using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectConsultants.Entity
{
    [Table("[ProjectInformation]")]
    public class ProjectInformationEntity
    {
        /// <summary>
        /// Gets or sets the project identifier.
        /// </summary>
        /// <value>
        /// The project identifier.
        /// </value>
        [Key]
        public int ProjectId { get; set; }
        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        /// <value>
        /// The name of the project.
        /// </value>
        public string ProjectName { get; set; }
        /// <summary>
        /// Gets or sets the project address1.
        /// </summary>
        /// <value>
        /// The project address1.
        /// </value>
        public string ProjectAddress1 { get; set; }
        /// <summary>
        /// Gets or sets the project address2.
        /// </summary>
        /// <value>
        /// The project address2.
        /// </value>
        public string ProjectAddress2 { get; set; }
        /// <summary>
        /// Gets or sets the project city.
        /// </summary>
        /// <value>
        /// The project city.
        /// </value>
        public string ProjectCity { get; set; }
        /// <summary>
        /// Gets or sets the state of the project.
        /// </summary>
        /// <value>
        /// The state of the project.
        /// </value>
        public string ProjectState { get; set; }
        /// <summary>
        /// Gets or sets the project postal code.
        /// </summary>
        /// <value>
        /// The project postal code.
        /// </value>
        public int ProjectPostalCode { get; set; }
        /// <summary>
        /// Gets or sets the project country.
        /// </summary>
        /// <value>
        /// The project country.
        /// </value>
        public string ProjectCountry { get; set; }
        /// <summary>
        /// Gets or sets the name of the owner.
        /// </summary>
        /// <value>
        /// The name of the owner.
        /// </value>
        public string OwnerName { get; set; }
        /// <summary>
        /// Gets or sets the owner address1.
        /// </summary>
        /// <value>
        /// The owner address1.
        /// </value>
        public string OwnerAddress1 { get; set; }
        /// <summary>
        /// Gets or sets the owner address2.
        /// </summary>
        /// <value>
        /// The owner address2.
        /// </value>
        public string OwnerAddress2 { get; set; }
        /// <summary>
        /// Gets or sets the owner city.
        /// </summary>
        /// <value>
        /// The owner city.
        /// </value>
        public string OwnerCity { get; set; }
        /// <summary>
        /// Gets or sets the state of the owner.
        /// </summary>
        /// <value>
        /// The state of the owner.
        /// </value>
        public string OwnerState { get; set; }
        /// <summary>
        /// Gets or sets the owner postal code.
        /// </summary>
        /// <value>
        /// The owner postal code.
        /// </value>
        public int OwnerPostalCode { get; set; }
        /// <summary>
        /// Gets or sets the owner country.
        /// </summary>
        /// <value>
        /// The owner country.
        /// </value>
        public string OwnerCountry { get; set; }
        /// <summary>
        /// Gets or sets the owner representative.
        /// </summary>
        /// <value>
        /// The owner representative.
        /// </value>
        public string OwnerRepresentative { get; set; }
        /// <summary>
        /// Gets or sets the owner email address.
        /// </summary>
        /// <value>
        /// The owner email address.
        /// </value>
        public string OwnerEmailAddress { get; set; }
        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>
        /// The mobile number.
        /// </value>
        public string MobileNumber { get; set; }
        /// <summary>
        /// Gets or sets the contract origin.
        /// </summary>
        /// <value>
        /// The contract origin.
        /// </value>
        public string ContractOrigin { get; set; }
        /// <summary>
        /// Gets or sets the type of the contract.
        /// </summary>
        /// <value>
        /// The type of the contract.
        /// </value>
        public string ContractType { get; set; }
        /// <summary>
        /// Gets or sets the type of the procurement.
        /// </summary>
        /// <value>
        /// The type of the procurement.
        /// </value>
        public string ProcurementType { get; set; }
    }
}
