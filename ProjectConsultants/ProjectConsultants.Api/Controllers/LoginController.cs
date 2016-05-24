


using ProjectConsultants.Action;
using ProjectConsultants.Entity;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectConsultants.Api.Controllers
{
    public class LoginController : ApiController
    {
        /// <summary>
        /// Users login.
        /// </summary>
        /// <param name="loginViewModel">The login view model.</param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage AuthenticateLogin(string UserName, string Password)
        {
            UserEntity userEntity = new UserEntity();
            userEntity.Email = UserName;
            userEntity.Password = Password;


            var login = new LoginManager().AuthenticateLogin(userEntity);
            if (login != null)
            {
                return Request.CreateResponse(login);
            }

            else
            {
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
        }

    }
}