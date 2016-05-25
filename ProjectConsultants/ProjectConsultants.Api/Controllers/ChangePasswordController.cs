using ProjectConsultants.Action;
using ProjectConsultants.Entity;
using System.Net.Http;
using System.Web.Http;

namespace ProjectConsultants.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class ChangePasswordController : ApiController
    {
        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="UserName">Name of the user.</param>
        /// <param name="Password">The password.</param>
        /// <param name="NewPassword">The new password.</param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage ChangePassword(string UserName, string Password,string NewPassword)
        {

            UserEntity userEntity = new UserEntity();
            userEntity.Email = UserName;
            userEntity.Password = Password;
            userEntity.NewPassword = NewPassword;

            var passwordExist  = new ChangePasswordManager().ChangePassword(userEntity);

            return Request.CreateResponse(passwordExist);
        }
    }
}
    

