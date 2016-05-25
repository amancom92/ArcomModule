using ProjectConsultants.Action;
using ProjectConsultants.Entity;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectConsultants.Api.Controllers
{
    public class UserController : ApiController
    {

       [HttpPost]
        public HttpResponseMessage Register(RegistrationViewModel register)
        {
            if (ModelState.IsValid)
            {
                UserEntity user = new UserEntity();
                user.FirstName = register.FirstName;
                user.LastName = register.LastName;
                user.Email = register.Email;
                user.Password = register.Password;
          
                user.CreatedOn = DateTime.Now;
                user.UpdatedOn = DateTime.Now;
                var newuser = new UserManager().Add(user);
                return Request.CreateResponse(newuser);

            }

            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="UserName">Name of the user.</param>
        /// <param name="Password">The password.</param>
        /// <param name="NewPassword">The new password.</param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage ChangePassword(string UserName, string Password, string NewPassword)
        {

            UserEntity userEntity = new UserEntity();
            userEntity.Email = UserName;
            userEntity.Password = Password;
            userEntity.NewPassword = NewPassword;

            var passwordExist = new UserManager().ChangePassword(userEntity);

            return Request.CreateResponse(passwordExist);
        }
    }
}
