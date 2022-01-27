using HPlus_App.Filters;
using System.Web;
using System.Web.Mvc;

namespace HPlus_App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
<<<<<<< HEAD
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new CrawlerFilter());
            filters.Add(new CustomExceptionHandler());
            filters.Add(new LogRequestFilter());
=======
            /*filters.Add(new HandleErrorAttribute());*/
            filters.Add(new LogRequestFilter());
            filters.Add(new CustomExceptionHandler());
>>>>>>> 6976662a5ab6e3db8a0d4789396607527501b474
        }
    }
}
