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

        #region Registration

        //    private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        //(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        // GET: Registration

        /// <summary>
        /// Registers this instance.
        /// </summary>
        /// <returns></returns>
        //[SkipCustomSessionFilter]
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
        //[SkipCustomSessionFilter]
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
                log.Error(ex.ToString());
            }

                return View(changePasswordViewModel);
            
        }
        #endregion Change Password

        #region EmailVaildate
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

        #endregion EmailVaildate





    }
}


