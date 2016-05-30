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
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(UserController));
        /// <summary>
        /// Registers the specified register.
        /// </summary>
        /// <param name="register">The register.</param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Register(RegisterViewModel register)
        {
            try
            {

                UserEntity user = new UserEntity();
                user.FirstName = register.FirstName;
                user.LastName = register.LastName;
                user.Email = register.Email;
                user.Password = register.Password;
                user.IsActive = true;
                user.CreatedBy = Convert.ToInt32(register.UserId);
                user.CreatedOn = DateTime.Now;
                user.UpdatedOn = DateTime.Now;
                if (ModelState.IsValid)
                {
                    var newuser = new UserManager().Add(user);
                    return Request.CreateResponse(newuser);

                }
                else
                {
                    ModelState.AddModelError("Error", "sorry!something went wrong");
                }
            }
            catch (Exception ex)
            {
                register.Message = ex.ToString();
                log.Error(ex.ToString());
                
            }
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

        [HttpGet]
        public HttpResponseMessage IsEmailValidate(string email)
        {
            try
            {
                var response = new HttpResponseMessage();

                var isEmail = new UserManager().EmailValidate(email);
                if (isEmail)
                {
                    return response = Request.CreateResponse(isEmail);

                }
                else
                {
                    ModelState.AddModelError("Error", "sorry!something went wrong");
                }

            }
            catch (Exception ex)
            {
                throw ex;
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
