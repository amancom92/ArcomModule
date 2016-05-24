using ProjectConsultants.Action;
using ProjectConsultants.Entity;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Net.Http;
using System.Web.Mvc;

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
        public ActionResult Register(RegistrationViewModel register)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   
                    HttpResponseMessage response = GetServiceResponse("api/Registration/Register");
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

        public JsonResult EmailExists(string email)
        {
            return Json(!String.Equals(email, "priya.gupta@gmail.com", StringComparison.OrdinalIgnoreCase));
        }
    }
}


