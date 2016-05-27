﻿using ProjectConsultants.Filters;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace ProjectConsultants.Controllers
{
    public class UserController : BaseController
    {
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
                    return RedirectToAction("Register", "User");
                }
            }
            catch (Exception ex)
            {
                register.Message = ex.ToString();

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
        [HttpGet]
        public JsonResult EmailDbValidation(string email)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64468/");

            HttpResponseMessage response = GetServiceResponse("api/User/IsEmailValidate?email=" + email);
                     
       try
            {
                bool  ifEmailExist = response!=null? true : false;
                return Json(ifEmailExist, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }
    }
}


