using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjectConsultants.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ProjectConsultants.Controllers.BaseController" />
    public class LogOutController : BaseController
    {
        /// <summary>
        /// Logs the out.
        /// </summary>
        /// <returns></returns>
        public ActionResult LogOut()
        {
            //LoggedInUser = null;
            Session["UserProfile"] = null;
            Session.RemoveAll();
            Session.Abandon();
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            //Response.Cache.SetNoStore();

            return RedirectToActionPermanent("Login", "Login");
        }
    }
}