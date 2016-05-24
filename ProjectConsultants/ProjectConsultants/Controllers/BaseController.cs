﻿using ProjectConsultants.Common;
using ProjectConsultants.ViewModel;
using System;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class BaseController : Controller
    {
        protected string GetModelStateErrors(ModelStateDictionary modelState)
        {
            return string.Join("\n", modelState.Keys.SelectMany(k => modelState[k].Errors).Select(m => m.ErrorMessage).Distinct().ToArray());
        }

        protected HttpResponseMessage GetServiceResponse(string requestedUrl)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Helper.ServiceUrl);
            return client.GetAsync(requestedUrl).Result;
        }

        /// <summary>
        /// Gets or sets the logged in user.
        /// </summary>
        /// <value>
        /// The logged in user.
        /// </value>
        protected UserSession LoggedInUser
        {
            get
            {
                var userProfile = new UserSession();
                if (Session["UserProfile"] != null)
                {
                    userProfile = Session["UserProfile"] as UserSession;
                }

                return userProfile;
            }
            set
            {
                Session["UserProfile"] = value;
            }
        }
    }
}