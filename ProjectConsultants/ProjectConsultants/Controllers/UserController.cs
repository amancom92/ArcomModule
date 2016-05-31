using ProjectConsultants.Filters;
using ProjectConsultants.Logging;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace ProjectConsultants.Controllers
{
    public class UserController : BaseController
    {
        /// <summary>
        /// The log
        /// </summary>
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(UserController));
        //    private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        //(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // GET: Registration

        /// <summary>
        /// Registers this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }
        //Inserting a new record
        /// <summary>
        /// Registers the specified register.
        /// </summary>
        /// <param name="register">The register.</param>
        /// <returns></returns>
        [HttpPost]

        public async Task<ActionResult> Register(RegisterViewModel register)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://localhost:64469/");
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/User/Register", register);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index", "Project");
                    }

                    else
                    {
                        return RedirectToAction("Register", "User");
                    }
                }
                else
                {
                    return RedirectToAction("Error", "Error");
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString(), ex);
            }

            return View(register);
        }




        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }
        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="changePasswordViewModel">The change password view model.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                HttpResponseMessage response = GetServiceResponse("api/User/ChangePassword?UserName=" + changePasswordViewModel.Email + "&Password=" + changePasswordViewModel.Password + "&NewPassword=" + changePasswordViewModel.NewPassword);
                if (response.IsSuccessStatusCode)
                {

                    return RedirectToActionPermanent("Index", "Project");
                }
            }
            return View(changePasswordViewModel);
        }

        /// <summary>
        /// Emails the database validation.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
      //for email vaildation if it already exist in database
        [HttpGet]

        public JsonResult EmailDbValidation(string email)
        {
            try
            {
                HttpResponseMessage response = GetServiceResponse("api/User/IsEmailValidate?email=" + email);
                var isEmailExists = response.Content.ReadAsAsync<bool>().Result;
                return Json(isEmailExists, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);

            }

        }



    }
}


