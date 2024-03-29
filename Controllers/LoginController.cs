﻿using System;
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
        public ActionResult Index(Login request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            if (!string.IsNullOrEmpty(request.Username) && !string.IsNullOrEmpty(request.Password))
            {
                FormsAuthentication.SetAuthCookie(request.Username, false);
                return Redirect(FormsAuthentication.GetRedirectUrl(request.Username, false));
            }
            ViewBag.Failed = true;
            return View(request);
        }
    }
}