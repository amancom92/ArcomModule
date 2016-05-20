using System.Linq;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class BaseController : System.Web.Mvc.Controller
    {
        protected string GetModelStateErrors(ModelStateDictionary modelState)
        {
            return string.Join("\n", modelState.Keys.SelectMany(k => modelState[k].Errors).Select(m => m.ErrorMessage).Distinct().ToArray());
        }
    }
}