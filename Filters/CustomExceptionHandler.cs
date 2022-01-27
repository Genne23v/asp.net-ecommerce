using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus_App.Filters
{
    public class CustomExceptionHandler : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
<<<<<<< HEAD
            var path = filterContext.HttpContext.Server.MapPath("/errors/500.html");
=======
            var path = filterContext.HttpContext.Server.MapPath("errors/500.html");
>>>>>>> 6976662a5ab6e3db8a0d4789396607527501b474
            var bytes = System.IO.File.ReadAllBytes(path);
            filterContext.Result = new FileContentResult(bytes, "text/html");
            filterContext.ExceptionHandled = true;
        }
    }
}