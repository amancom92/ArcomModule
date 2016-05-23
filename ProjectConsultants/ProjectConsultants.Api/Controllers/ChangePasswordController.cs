using ProjectConsultants.Action;
using ProjectConsultants.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectConsultants.Api.Controllers
{
    public class ChangePasswordController : ApiController
    {
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
    

