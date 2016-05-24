﻿using ProjectConsultants.Common;
using System;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// Gets the model state errors.
        /// </summary>
        /// <param name="modelState">State of the model.</param>
        /// <returns></returns>
        protected string GetModelStateErrors(ModelStateDictionary modelState)
        {
            return string.Join("\n", modelState.Keys.SelectMany(k => modelState[k].Errors).Select(m => m.ErrorMessage).Distinct().ToArray());
        }

<<<<<<< HEAD
        /// <summary>
        /// Gets the service response.
        /// </summary>
        /// <param name="requestedUrl">The requested URL.</param>
        /// <returns></returns>
  
=======
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
        protected UserProfile LoggedInUser
        {
            get
            {
                var userProfile = new UserProfile();
                if (Session["UserProfile"] != null)
                {
                    userProfile = Session["UserProfile"] as UserProfile;
                }

                return userProfile;
            }
            set
            {
                Session["UserProfile"] = value;
            }
        }
>>>>>>> 311271fb6da5a2d0ede46c5f4e80d90a9bda6701
    }
}