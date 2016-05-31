using ProjectConsultants.Action;
using ProjectConsultants.Api.App_Start;
using ProjectConsultants.Entity;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectConsultants.Api.Controllers
{
    public class UserController : BaseController
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


                var newuser = new UserManager().Add(user);
                return Request.CreateResponse(newuser);

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

            var response = new HttpResponseMessage();

            var isEmail = new UserManager().EmailValidate(email);
            if (isEmail)
            {
                return response = Request.CreateResponse(isEmail);


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
        /// <param name="changePasswordModel">The change password model.</param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage ChangePassword(ChangePasswordViewModel changePasswordModel)
        {
            try
            {
                UserEntity userEntity = MapperConfig.ConvertChangePasswordModelToEntity(changePasswordModel);
                var isSuccess = new UserManager().ChangePassword(userEntity);

                changePasswordModel.IsSuccess = isSuccess;
                if (isSuccess)
                {
                    ResponseStatusCode = HttpStatusCode.OK;
                }
                else
                {
                    ResponseStatusCode = HttpStatusCode.InternalServerError;
                }

                return Request.CreateResponse(ResponseStatusCode, changePasswordModel);
            }
            catch (Exception ex)
            {
                ResponseStatusCode = HttpStatusCode.InternalServerError;
                return Request.CreateResponse(ResponseStatusCode);
            }
        }
    }
}
