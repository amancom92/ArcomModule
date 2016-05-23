using ProjectConsultants.DataAccess;
using ProjectConsultants.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class ManageController : BaseController
    {
        // GET: Manage
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(UserEntity user )
        {
            if(ModelState.IsValid)
            {
                ProjectInformationDa register = new ProjectInformationDa();
                register.Register(user);
               
            }
            return RedirectToAction("Index", "Project");
        }
    }
}