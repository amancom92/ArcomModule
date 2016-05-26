using System.Web.Mvc;

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
            LoggedInUser = null;
            Session.RemoveAll();
            Session.Abandon();

            return RedirectToActionPermanent("Login", "Login");
        }
    }
}