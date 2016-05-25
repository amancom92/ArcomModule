using ProjectConsultants.UI.ViewModel;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjectConsultants.Controllers
{
    public class UserController : BaseController
    {
        // GET: Registration
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegistrationViewModel register)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://localhost:64468/");
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/User/Register", register);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index", "Project");
                    }
                }
                else
                {
                    var errorMessage = GetModelStateErrors(ModelState);
                }
            }
            catch (Exception ex)
            {
                register.Message = "Internal Server Error.";
            }

            return View(register);
        }

        [HttpPost]
        public JsonResult EmailExists(string email)
        {
            var user = Membership.GetUserNameByEmail(email);
            return Json(user == null);


        }

        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }
        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="changePasswordViewModel">The change password view model.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                HttpResponseMessage response = GetServiceResponse("api/User/ChangePassword?UserName=" + changePasswordViewModel.Email + "&Password=" + changePasswordViewModel.Password + "&NewPassword=" + changePasswordViewModel.NewPassword);
                if (response.IsSuccessStatusCode)
                {

                    return RedirectToActionPermanent("Index", "Project");
                }
            }
            return View(changePasswordViewModel);
        }

    }
}


