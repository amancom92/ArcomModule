using ProjectConsultants.Action;
using ProjectConsultants.Entity;
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
            var response = new HttpResponseMessage();
            try
            {
                UserEntity userEntity = new UserEntity();
                userEntity.Email = UserName;
                userEntity.Password = Password;

                var login = new LoginManager().AuthenticateLogin(userEntity);
                if (login != null)
                {
                    response = Request.CreateResponse(login);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.NoContent);
                }
            }
            catch (Exception ex)
            {
            }

            return response;
        }

    }
}