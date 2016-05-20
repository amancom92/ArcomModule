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
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://rcom.compunnel.com/service/");

                    HttpResponseMessage response = client.GetAsync("api/Login/AuthenticateLogin?UserName=" + loginViewModel.UserName + "&Password=" + loginViewModel.Password).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToActionPermanent("Index", "Project");
                    }
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception((int)response.StatusCode + "-" + response.StatusCode.ToString());
                    }
                    //else
                    //{
                    //    // problems handling here
                    //    Console.WriteLine("Error occurred, the status code is: {0}",response.StatusCode);
                    //}
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



