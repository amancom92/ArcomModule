using ProjectConsultants.Api.App_Start;
using System.Web.Http;

namespace ProjectConsultants.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
