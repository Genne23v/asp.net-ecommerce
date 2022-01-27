using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HPlus_App.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.Login request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            if (!string.IsNullOrEmpty(request.Username) && !string.IsNullOrEmpty(request.Password))
            {
                FormsAuthentication.SetAuthCookie(request.Username, false);
                string path = FormsAuthentication.GetRedirectUrl(request.Username, false);
                return Redirect(path);
            }
            ViewBag.Failed = true;
            return View(request);
        }
    }
}