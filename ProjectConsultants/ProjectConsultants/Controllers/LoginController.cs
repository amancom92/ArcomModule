﻿using ProjectConsultants.Common;
using ProjectConsultants.Filters;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Net;
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
        [SkipCustomSessionFilter]
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
        [SkipCustomSessionFilter]
        public async Task<ActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var serviceUrl = "api/Loginn/AuthenticateLogin?UserName=" + loginViewModel.UserName + "&Password=" + loginViewModel.Password;
                HttpResponseMessage response = GetServiceResponse(serviceUrl);
                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsAsync<UserViewModel>();
                    if (responseResult == null)
                    {
                        ViewBag.Message = "The email and password you entered don't match.";
                        return View();
                    }
                    try
                    {
                        var userViewModel = new UserSession
                        {
                            FirstName = responseResult.FirstName,
                            LastName = responseResult.LastName,
                            UserId = responseResult.UserId,
                            Email = responseResult.Email
                        };

                        //Storing user information in session
                        LoggedInUser = responseResult;
                    }
                    catch (Exception ex)
                    {
                        var Message = ex.ToString();
                    }

                    return RedirectToAction("Index", "Project");
                }
                else
                {
                    return RedirectToActionPermanent("Error", "Error");
                }
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
        }

    }
}



