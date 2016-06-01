using System.Net;
using System.Web.Http;

namespace ProjectConsultants.Api.Controllers
{
    public class BaseController : ApiController
    {
        /// <summary>
        /// The HTTP status code
        /// </summary>
        HttpStatusCode httpStatusCode = HttpStatusCode.OK;

        /// <summary>
        /// The Response state code.
        /// </summary>
        /// <value>
        /// The response status code.
        /// </value>
        internal HttpStatusCode ResponseStatusCode
        {
            get { return httpStatusCode; }
            set { httpStatusCode = value; }
        }
    }
}
