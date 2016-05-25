using ProjectConsultants.Action;
using ProjectConsultants.Entity;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace ProjectConsultants.Api.Controllers
{
    public class ProjectController : ApiController
    {
        public HttpResponseMessage AddProject(ProjectInformationViewModel projectInformationViewModel)
        {
            if (ModelState.IsValid)
            {
                var projectManager = new ProjectManager();
                ProjectInformationEntity projectEntity = new ProjectInformationEntity();
                projectEntity.ProjectName = projectInformationViewModel.ProjectName;
                projectEntity.ContractOrigin = Convert.ToString(projectInformationViewModel.ContractOriginId);
                projectEntity.ContractType = Convert.ToString(projectInformationViewModel.ContractTypeId);
                projectEntity.MobileNumber = projectInformationViewModel.MobileNumber;
                projectEntity.OwnerAddress1 = projectInformationViewModel.OwnerAddress1;
                projectEntity.OwnerAddress2 = projectInformationViewModel.OwnerAddress2;
                projectEntity.OwnerCity = projectInformationViewModel.OwnerCity;
                projectEntity.OwnerCountry = Convert.ToString(projectInformationViewModel.OwnerCountryId);
                projectEntity.OwnerEmailAddress = projectInformationViewModel.OwnerEmailAddress;
                projectEntity.OwnerName = projectInformationViewModel.OwnerName;
                projectEntity.OwnerPostalCode = projectInformationViewModel.OwnerPostalCode;
                projectEntity.OwnerRepresentative = projectInformationViewModel.OwnerRepresentative;
                projectEntity.OwnerState = Convert.ToString(projectInformationViewModel.OwnerStateId);
                projectEntity.PhoneNumber = projectInformationViewModel.PhoneNumber;
                projectEntity.ProcurementType = Convert.ToString(projectInformationViewModel.ProcurementTypeId);
                projectEntity.ProjectAddress1 = projectInformationViewModel.ProjectAddress1;
                projectEntity.ProjectCity = projectInformationViewModel.ProjectCity;
                projectEntity.ProjectCountry = Convert.ToString(projectInformationViewModel.ProjectCountryId);
                projectEntity.ProjectId = projectInformationViewModel.ProjectId;
                projectEntity.ProjectPostalCode = projectInformationViewModel.ProjectPostalCode;
                projectEntity.ProjectState = Convert.ToString(projectInformationViewModel.ProjectStateId);
                projectEntity.ProjectAddress2 = projectInformationViewModel.ProjectAddress2;
                var outputList = projectManager.Add(projectEntity);
            }
            else
            {
                var errorMessage = GetModelStateErrors(ModelState);
            }
            return Request.CreateResponse(true);
        }

        private object GetModelStateErrors(ModelStateDictionary modelState)
        {
            throw new NotImplementedException();
        }
    }
}
