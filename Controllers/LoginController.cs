using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using HPlus.Ecommerce.Models;

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
<<<<<<< HEAD
        public ActionResult Index(Models.Login request)
=======
        public ActionResult Index(Login request)
>>>>>>> 6976662a5ab6e3db8a0d4789396607527501b474
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            if (!string.IsNullOrEmpty(request.Username) && !string.IsNullOrEmpty(request.Password))
            {
                FormsAuthentication.SetAuthCookie(request.Username, false);
<<<<<<< HEAD
                string path = FormsAuthentication.GetRedirectUrl(request.Username, false);
                return Redirect(path);
=======
                return Redirect(FormsAuthentication.GetRedirectUrl(request.Username, false));
>>>>>>> 6976662a5ab6e3db8a0d4789396607527501b474
            }
            ViewBag.Failed = true;
            return View(request);
        }
    }
}