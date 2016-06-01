using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectConsultants.Filters
{
    public class CustomSessionFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)

        {
            base.OnActionExecuting(filterContext);

            if (filterContext.ActionDescriptor.GetCustomAttributes(typeof(SkipCustomSessionFilter), false).Length > 0)
                return;


            // Now check the session:
            var userSession = filterContext.HttpContext.Session["UserProfile"];

            if (userSession == null)
            {
                // Redirect
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                   {
                  { "controller", "Login" },
                  { "action", "Login" }
                    });
            }


      }
    }

}