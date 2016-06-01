using ProjectConsultants.Filters;
using System;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class HomeController : Controller
    {
        [SkipCustomSessionFilter]
        // log4net.ILog logger = log4net.LogManager.GetLogger(typeof(HomeController));  //Declaring Log4Net  
        public ActionResult Index()
        {
            //try
            //{
                int x, y, z;
                x = 5; y = 0;
                z = x / y;
            //}
            //catch (Exception ex)
            //{
                //logger.Error(ex.ToString());
            //}
            return View();
        }

      
    }
}
     