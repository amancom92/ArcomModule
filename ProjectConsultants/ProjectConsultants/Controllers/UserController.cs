using ProjectConsultants.UI.ViewModel;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class UserController : BaseController
    {
        #region Registration
        // GET: Registration
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel register)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://localhost:64468/");
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/User/Register", register);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index", "Project");
                    }
                }
                else
                {
                    var errorMessage = GetModelStateErrors(ModelState);
                }
            }
            catch (Exception ex)
            {
                register.Message = "Internal Server Error.";
            }

            return View(register);
        }

        /// <summary>
        /// Emails the database validation.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult EmailDbValidation(string email)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64468/");

            HttpResponseMessage response = GetServiceResponse("api/User/IsEmailValidate?email=" + email);

            try
            {
                bool ifEmailExist = response != null ? true : false;
                return Json(ifEmailExist, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }

        #endregion Registration

        #region Change Password

        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ChangePassword()
        {
            if (LoggedInUser == null)
            {
                return RedirectToActionPermanent("Login", "Login");
            }

            return View();
        }

        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="changePasswordViewModel">The change password view model.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                     var serviceUrl = string.Format("api/User/ChangePassword");
                    HttpResponseMessage response = await GetClient().PostAsJsonAsync(serviceUrl, changePasswordViewModel);

                    var responseResult = response.Content.ReadAsAsync<ChangePasswordViewModel>().Result;
                    if (responseResult != null)
                    {
                        changePasswordViewModel.Message = responseResult.Message;
                        changePasswordViewModel.IsSuccess = response.IsSuccessStatusCode;
                    }                   
                }
            }
            catch (Exception ex)
            {
               
            }

            return View(changePasswordViewModel);
        }

        #endregion Change Password
    }
}


