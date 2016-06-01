using ProjectConsultants.App_Start;
using System.Web.Mvc;
using System.IO;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjectConsultants
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            log4net.Config.XmlConfigurator.Configure(new FileInfo("~/log4net.config"));
        }
      

    }
}

