using ProjectConsultants.Common;
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
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpResponseMessage response = GetServiceResponse("api/Login/AuthenticateLogin?UserName=" + loginViewModel.UserName + "&Password=" + loginViewModel.Password);
                    if (response.IsSuccessStatusCode)
                    {
                        UserProfile userprofile = new UserProfile
                        {
                            Id = loginViewModel.Id,
                            UserName = loginViewModel.UserName
                        };

                        //Storing user information in session
                        //Session["uname"] = loginViewModel.UserName;
                        LoggedInUser = userprofile;

                        return RedirectToActionPermanent("Index", "Project");
                    }
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception((int)response.StatusCode + "-" + response.StatusCode.ToString());
                    }
                }
                else
                {
                    var errorMessage = GetModelStateErrors(ModelState);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(loginViewModel);
        }

    }
}



