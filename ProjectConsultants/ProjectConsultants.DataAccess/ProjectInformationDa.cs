using ProjectConsultants.Entity;

namespace ProjectConsultants.DataAccess
{
    public class ProjectInformationDa
    {
        /// <summary>
        /// Adds the specified project data.
        /// </summary>
        /// <param name="projectData">The project data.</param>
        /// <returns></returns>
        public ProjectInformationEntity Add(ProjectInformationEntity projectData)
        {
            using (var context = new ArcomDbContext())
            {
                var projectDetail = context.projectInformation.Add(projectData);
                context.SaveChanges();
                return projectDetail;
            }
        }

        public UserEntity Register(UserEntity user)
        {
            using (var context = new ArcomDbContext())
            {
                var userdetails = context.userInformation.Add(user);
                context.SaveChanges();
                return userdetails;
            }
        }

    }
}
