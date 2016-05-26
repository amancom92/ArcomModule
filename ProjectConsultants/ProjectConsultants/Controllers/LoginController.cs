using ProjectConsultants.UI.ViewModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

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
            if (ModelState.IsValid)
            {
                var serviceUrl = "api/Login/AuthenticateLogin?UserName=" + loginViewModel.UserName + "&Password=" + loginViewModel.Password;
                HttpResponseMessage response = GetServiceResponse(serviceUrl);
                if (response.IsSuccessStatusCode)
                {
                    var responseEntity = await response.Content.ReadAsAsync<UserViewModel>();

                    UserViewModel userViewModel = new UserViewModel
                    {
                        FirstName = responseEntity.FirstName,
                        LastName = responseEntity.LastName,
                        UserId = responseEntity.UserId,
                        Email = responseEntity.Email
                    };
                    //Storing user information in session
                    LoggedInUser = userViewModel;
                    return RedirectToActionPermanent("Index", "Project");
                }

                //if (!response.IsSuccessStatusCode)
                //{
                //    throw new Exception((int)response.StatusCode + "-" + response.StatusCode.ToString());
                //}
            }
            else
            {
                var errorMessage = GetModelStateErrors(ModelState);
            }

            return View(loginViewModel);
        }

        public ActionResult SignOut()
        {
            Session["UserProfile"] = null;
            Session.RemoveAll();
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
            //return View();
        }

    }
}



