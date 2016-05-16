using ProjectConsultants.Entity;
using System.Data.Entity;

namespace ProjectConsultants.DataAccess
{
  
    public sealed class ArcomDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArcomDbContext"/> class.
        /// </summary>
        public ArcomDbContext()
            : base("name=DbConnectionString")
        {
        }
        /// <summary>
        /// Gets or sets the project information.
        /// </summary>
        /// <value>
        /// The project information.
        /// </value>
        public DbSet<ProjectInformationEntity> projectInformation { get; set; }

    }
}
