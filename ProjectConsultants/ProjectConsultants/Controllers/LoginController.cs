using ProjectConsultants.Common;
using ProjectConsultants.UI.ViewModel;
using ProjectConsultants.ViewModel;
using System;
using System.Net.Http;
using System.Threading.Tasks;
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
        public async Task<ActionResult> Login(LoginViewModel loginViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpResponseMessage response = GetServiceResponse("api/Login/AuthenticateLogin?UserName=" + loginViewModel.UserName + "&Password=" + loginViewModel.Password);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseEntity =  await response.Content.ReadAsAsync<UserSession>();

                        //UserSession userprofile = new UserSession
                        //{
                        //    UserId = loginViewModel.UserId,
                        //    UserName = loginViewModel.UserName,
                        //    FirstName= loginViewModel.FirstName,
                        //    LastName= loginViewModel.LastName
                        //};
                        //UserViewModel userViewModel = new UserViewModel()
                        //{
                        //    UserId = ,
                        //    UserName = ,
                        //    FirstName = ,
                        //    LastName =

                        //};

                        //Storing user information in session

                        LoggedInUser = responseEntity;
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



