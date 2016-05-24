using ProjectConsultants.Action;
using ProjectConsultants.Entity;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectConsultants.Api.Controllers
{
    public class RegistrationController : ApiController
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
                var newuser = new Register().Add(user);
                return Request.CreateResponse(newuser);

            }

            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}
