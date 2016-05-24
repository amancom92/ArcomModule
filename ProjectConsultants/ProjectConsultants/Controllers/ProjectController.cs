using ProjectConsultants.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class ProjectController : BaseController
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {


            var projectInformation = new ProjectInformationViewModel();
            //Initializing property to fill object value
            HttpResponseMessage response = FillPropertyValue(projectInformation);

            projectInformation.ProjectStateId = 0;
            projectInformation.OwnerStateId = 0;
            projectInformation.ContractTypeId = 0;
            projectInformation.ProjectCountryId = 0;
            projectInformation.OwnerCountryId = 0;
            projectInformation.ProcurementTypeId = 0;
            projectInformation.ContractOriginId = 0;

            projectInformation.ProjectStateList = new List<SelectListItem>();
            projectInformation.OwnerStateList = new List<SelectListItem>();
            //if (Session["uname"] == null)
            //{
            //    return RedirectToActionPermanent("Login", "Login");
            //}
            //else
            //{
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();

            return View(projectInformation);
            //}

        }

        private HttpResponseMessage FillPropertyValue(ProjectInformationViewModel projectInformation)
        {


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64468/");

            HttpResponseMessage response = client.GetAsync("api/Common/GetCountryList").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                projectInformation.ProjectCountryList = responseList;
            }
            else
                projectInformation.ProjectCountryList = new List<SelectListItem>();

            response = GetServiceResponse("api/Common/GetCountryList");
            if (response.IsSuccessStatusCode)
            {
                var responseList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                projectInformation.OwnerCountryList = responseList;
            }
            else
                projectInformation.OwnerCountryList = new List<SelectListItem>();

            response = GetServiceResponse("api/Common/GetOriginContractList");
            if (response.IsSuccessStatusCode)
            {
                var responseList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                projectInformation.ContractOriginList = responseList;
            }
            else
                projectInformation.ContractOriginList = new List<SelectListItem>();

            response = GetServiceResponse("api/Common/GetProcurementList");
            if (response.IsSuccessStatusCode)
            {
                var responseList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                projectInformation.ProcurementTypeList = responseList;
            }
            else
                projectInformation.ProcurementTypeList = new List<SelectListItem>();

            response = GetServiceResponse("api/Common/GetContractList");
            if (response.IsSuccessStatusCode)
            {
                var responseList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                projectInformation.ContractTypeList = responseList;
            }
            else
                projectInformation.ContractTypeList = new List<SelectListItem>();
            return response;
        }

        /// <summary>
        /// Indexes the specified project information view model.
        /// </summary>
        /// <param name="projectInformationViewModel">The project information view model.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(ProjectInformationViewModel projectInformationViewModel)
        {
            if (ModelState.IsValid)
            {
                //ProjectInformationEntity projectEntity = new ProjectInformationEntity();
                //projectEntity.ProjectName = projectInformationViewModel.ProjectName;
                //projectEntity.ContractOrigin = Convert.ToString(projectInformationViewModel.ContractOriginId);
                //projectEntity.ContractType = Convert.ToString(projectInformationViewModel.ContractTypeId);
                //projectEntity.MobileNumber = projectInformationViewModel.MobileNumber;
                //projectEntity.OwnerAddress1 = projectInformationViewModel.OwnerAddress1;
                //projectEntity.OwnerAddress2 = projectInformationViewModel.OwnerAddress2;
                //projectEntity.OwnerCity = projectInformationViewModel.OwnerCity;
                //projectEntity.OwnerCountry = Convert.ToString(projectInformationViewModel.OwnerCountryId);
                //projectEntity.OwnerEmailAddress = projectInformationViewModel.OwnerEmailAddress;
                //projectEntity.OwnerName = projectInformationViewModel.OwnerName;
                //projectEntity.OwnerPostalCode = projectInformationViewModel.OwnerPostalCode;
                //projectEntity.OwnerRepresentative = projectInformationViewModel.OwnerRepresentative;
                //projectEntity.OwnerState = Convert.ToString(projectInformationViewModel.OwnerStateId);
                //projectEntity.PhoneNumber = projectInformationViewModel.PhoneNumber;
                //projectEntity.ProcurementType = Convert.ToString(projectInformationViewModel.ProcurementTypeId);
                //projectEntity.ProjectAddress1 = projectInformationViewModel.ProjectAddress1;
                //projectEntity.ProjectCity = projectInformationViewModel.ProjectCity;
                //projectEntity.ProjectCountry = Convert.ToString(projectInformationViewModel.ProjectCountryId);
                //projectEntity.ProjectId = projectInformationViewModel.ProjectId;
                //projectEntity.ProjectPostalCode = projectInformationViewModel.ProjectPostalCode;
                //projectEntity.ProjectState = Convert.ToString(projectInformationViewModel.ProjectStateId);
                //projectEntity.ProjectAddress2 = projectInformationViewModel.ProjectAddress2;

                //var entity = new CommonManager().Add(projectEntity);
                projectInformationViewModel = new ProjectInformationViewModel();
            }
            else
            {
                var errorMessage = GetModelStateErrors(ModelState);
            }

            var projectInformation = new ProjectInformationViewModel();
            HttpResponseMessage response = FillPropertyValue(projectInformation);

            projectInformation.ProjectStateId = 0;
            projectInformation.OwnerStateId = 0;
            projectInformation.ContractTypeId = 0;
            projectInformation.ProjectCountryId = 0;
            projectInformation.OwnerCountryId = 0;
            projectInformation.ProcurementTypeId = 0;
            projectInformation.ContractOriginId = 0;

            projectInformation.ProjectStateList = new List<SelectListItem>();
            projectInformation.OwnerStateList = new List<SelectListItem>();


            // Redirect to the same page
            //Response.Redirect(Request.Url.PathAndQuery, true);
            return View(projectInformationViewModel);
        }

        /// <summary>
        /// This Action Method is Temporary.
        /// </summary>
        /// <returns></returns>
        public ActionResult Temp()
        {
            return View();
        }

        /// <summary>
        /// Gets the states of Project.
        /// </summary>
        /// <param name="Country">The country.</param>
        /// <returns></returns>
        public JsonResult GetStates(int countryId)
        {
            List<SelectListItem> states = new List<SelectListItem>();
            var client = new HttpClient();


            //HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64468/");
            //set the Content-Type to application/json
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = GetServiceResponse("api/Common/GetStatesByCountryId?countryId=" + countryId);
            if (response.IsSuccessStatusCode)
            {
                var responseList = response.Content.ReadAsAsync<List<SelectListItem>>().Result;
                states = responseList;
            }

            return Json(new SelectList(states, "Value", "Text"));
        }

        /// <summary>
        /// Gets the owner states.
        /// </summary>
        /// <param name="ownerCountry">The owner country.</param>
        /// <returns></returns>
        public JsonResult GetOwnerStates(int countryId)
        {
            List<SelectListItem> ownerStates = new List<SelectListItem>();


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64468/");
            //var client = new HttpClient();

            //set the Content-Type to application/json
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = GetServiceResponse("api/Common/GetStatesByCountryId?countryId=" + countryId);
            if (response.IsSuccessStatusCode)
            {
                var responseList = response.Content.ReadAsAsync<List<SelectListItem>>().Result;
                ownerStates = responseList;
            }


            return Json(new SelectList(ownerStates, "Value", "Text"));


        }

    }
}