using ProjectConsultants.UI.ViewModel;
using System;
using System.Net.Http;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class LoginController : BaseController
    {
        /// <summary>
        /// Logins this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Logins the specified login view model.
        /// </summary>
        /// <param name="loginViewModel">The login view model.</param>
        /// <returns></returns>
        //[HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {               
                HttpResponseMessage response = GetServiceResponse("api/Login/AuthenticateLogin?UserName=" + loginViewModel.UserName + "&Password=" + loginViewModel.Password);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToActionPermanent("Index", "Project");
                }
            }
            return View(loginViewModel);
        }

    }
}