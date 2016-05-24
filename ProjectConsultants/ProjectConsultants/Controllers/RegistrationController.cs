using ProjectConsultants.UI.ViewModel;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjectConsultants.Controllers
{
    public class RegistrationController : BaseController
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
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/Registration/Register", register); 
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
 
    }
}


