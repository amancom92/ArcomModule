using ProjectConsultants.Filters;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class ErrorController : Controller
    {
        [SkipCustomSessionFilter]
        public ActionResult Error()
        {
            return View();
        }
    }
}