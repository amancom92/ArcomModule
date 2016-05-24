using ProjectConsultants.DataAccess;
using ProjectConsultants.Entity;

namespace ProjectConsultants.Action
{
    public class ProjectManager
    {
        /// <summary>
        /// Adds the specified project data.
        /// </summary>
        /// <param name="projectData">The project data.</param>
        /// <returns></returns>
        public ProjectInformationEntity Add(ProjectInformationEntity projectData)
        {
            var projectDetail = new ProjectInformationDa().Add(projectData);
            return projectDetail;
        }
    }
}
