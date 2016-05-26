using ProjectConsultants.Common;
using ProjectConsultants.Filters;
using System;
using System.Web;
using System.Web.Mvc;

namespace ProjectConsultants.Filters
{
    public class CustomSessionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            // Now check the session:
            var checkSession = filterContext.HttpContext.Session["UserProfile"];

            if (checkSession == null)
            {
                // Redirect
                //var url = new UrlHelper(filterContext.RequestContext);
                //var loginUrl = url.Content("~/Login/Login");
                //filterContext.HttpContext.Response.Redirect(loginUrl, true);
            }

        }
    }

    //public class NoCacheAttribute : ActionFilterAttribute
    //{
    //    public override void OnResultExecuting(ResultExecutingContext filterContext)
    //    {
    //        filterContext.HttpContext.Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
    //        filterContext.HttpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
    //        filterContext.HttpContext.Response.Cache.SetNoStore();

    //         base.OnResultExecuting(filterContext);


    //    }
    //}
}