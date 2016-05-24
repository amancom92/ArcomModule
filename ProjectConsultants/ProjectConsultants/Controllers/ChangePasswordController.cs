using ProjectConsultants.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ProjectConsultants.Controllers.BaseController" />
    public class ChangePasswordController : BaseController
    {

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
            HttpResponseMessage response = GetServiceResponse("api/ChangePassword/ChangePassword?UserName=" + changePasswordViewModel.Email + "&Password=" + changePasswordViewModel.Password + "&NewPassword=" + changePasswordViewModel.NewPassword);
            if (response.IsSuccessStatusCode)
            {

                return RedirectToActionPermanent("Index", "Project");
            }
            }
            return View(changePasswordViewModel);
        }
    }
}




