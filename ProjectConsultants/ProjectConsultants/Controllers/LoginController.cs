﻿using ProjectConsultants.Common;
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
            if (ModelState.IsValid)
            {
                var serviceUrl = "api/Login/AuthenticateLogin?UserName=" + loginViewModel.UserName + "&Password=" + loginViewModel.Password;
                HttpResponseMessage response = GetServiceResponse(serviceUrl);
                if (response.IsSuccessStatusCode)
                {
                    var responseEntity = await response.Content.ReadAsAsync<UserSession>();

                    //Storing user information in session
                    LoggedInUser = responseEntity;
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

        /// <summary>
        /// Logs the out.
        /// </summary>
        /// <returns></returns>
        public ActionResult LogOut()
        {
            LoggedInUser = null;
            Session["UserProfile"] = null;
            Session.RemoveAll();
            Session.Abandon();

            return RedirectToActionPermanent("Login", "Login");
        }
    }
}



