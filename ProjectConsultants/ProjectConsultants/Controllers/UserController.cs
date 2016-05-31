using ProjectConsultants.Filters;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace ProjectConsultants.Controllers
{
    public class UserController : BaseController
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(UserController));
        // GET: Registration

        /// <summary>
        /// Registers this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SkipCustomSessionFilter]
        public ActionResult Register()
        {
            var registerViewModel = new RegisterViewModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64468/");
            HttpResponseMessage response = client.GetAsync("api/Common/GetSecurityQuestionList").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                registerViewModel.SecurityQuestionList = responseList;
            }
            else
                registerViewModel.SecurityQuestionList = new List<SelectListItem>();
            return View(registerViewModel);
        }
        //Inserting a new record
        /// <summary>
        /// Registers the specified register.
        /// </summary>
        /// <param name="register">The register.</param>
        /// <returns></returns>
        [HttpPost]
        [SkipCustomSessionFilter]
        public async Task<ActionResult> Register(RegisterViewModel register)
        {
            //Log4NetLogger log = new Log4NetLogger();
           
          
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
            }
            catch (Exception ex)
            {
              
                log.Error(ex.ToString(),ex);
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

        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgotPassword(RegisterViewModel forgotPassword)
        {
            return View(forgotPassword);
        }

    }
}


