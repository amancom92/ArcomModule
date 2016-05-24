using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectConsultants
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
<<<<<<< HEAD
                defaults: new { controller = "Registration", action = "Register", id = UrlParameter.Optional }
=======
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
>>>>>>> 311271fb6da5a2d0ede46c5f4e80d90a9bda6701
            );
        }
    }
}
