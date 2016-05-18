using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class ManageController : BaseController
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}