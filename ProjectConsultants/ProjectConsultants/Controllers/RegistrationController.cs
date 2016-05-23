using ProjectConsultants.Action;
using ProjectConsultants.Entity;
using ProjectConsultants.UI.ViewModel;
using System;
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
            if (ModelState.IsValid)
            {
                UserEntity user = new UserEntity();
                user.FirstName = register.FirstName;
                user.LastName = register.LastName;
                user.Email = register.Email;
                user.Password = register.Password;
                var newuser = new Register().Add(user);
                return RedirectToAction("Index", "Project");

            }
            return View(register) ;
        }

        public JsonResult EmailExists(string email)
        {
            return Json(!String.Equals(email, "priya.gupta@gmail.com", StringComparison.OrdinalIgnoreCase));
        }
    }
}


