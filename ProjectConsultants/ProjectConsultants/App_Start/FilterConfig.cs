using ProjectConsultants.Filters;
using System.Web.Mvc;

namespace ProjectConsultants.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomSessionFilter());
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomExceptionFilter());
        }
    }
}