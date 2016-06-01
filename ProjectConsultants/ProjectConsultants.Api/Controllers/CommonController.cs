using ProjectConsultants.Action;
using System.Net.Http;
using System.Web.Http;

namespace ProjectConsultants.Api.Controllers
{
    public class CommonController : ApiController
    {
        /// <summary>
        /// Gets the origin contract list.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage GetOriginContractList()
        {
            var commonManager = new CommonManager();
            var outputList = commonManager.GetOriginContractList();
            return Request.CreateResponse(outputList);
        }

        /// <summary>
        /// Gets the contract list.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage GetContractList()
        {
            var commonManager = new CommonManager();
            var outputList = commonManager.GetContractList();
            return Request.CreateResponse(outputList);
        }

        /// <summary>
        /// Gets the procurement list.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage GetProcurementList()
        {
            var commonManager = new CommonManager();
            var outputList = commonManager.GetProcurementList();
            return Request.CreateResponse(outputList);
        }

        /// <summary>
        /// Gets the state list.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage GetStateList()
        {
            var commonManager = new CommonManager();
            var outputList = commonManager.GetStateList();
            return Request.CreateResponse(outputList);
        }

        /// <summary>
        /// Gets the country list.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage GetCountryList()
        {
            var commonManager = new CommonManager();
            var outputList = commonManager.GetCountryList();
            return Request.CreateResponse(outputList);
        }
        
        public HttpResponseMessage GetSecurityQuestionList()
        {
            var securityQuestionsManager = new SecurityQuestionsManager();
            var outputList = securityQuestionsManager.GetSecurityQuestionList();
            return Request.CreateResponse(outputList);
        }

        /// <summary>
        /// Gets the states by country identifier.
        /// </summary>
        /// <param name="countryId">The country identifier.</param>
        /// <returns></returns>
        public HttpResponseMessage GetStatesByCountryId(int countryId)
        {
            var commonManager = new CommonManager();
            var outputList = commonManager.GetStatesByCountryId(countryId);
            return Request.CreateResponse(outputList);
        }

    }
}
