
using ProjectConsultants.Api.App_Start;
﻿using ProjectConsultants.Filters;
using System.Web.Http;

namespace ProjectConsultants.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //To apply the filter globally to all Web API controllers
            GlobalConfiguration.Configuration.Filters.Add(new CustomApiExceptionFilter());
        }
    }
}
