<<<<<<< HEAD
﻿using HPlus.Ecommerce.Data;
using HPlus.Ecommerce.Data.Entities;
=======
﻿using HPlus.Ecommerce.Data.Entities;
using HPlus_App.Data;
>>>>>>> 6976662a5ab6e3db8a0d4789396607527501b474
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus_App.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
<<<<<<< HEAD
            using (var ctx = new HPlusSportDbContext())
                    {
                Customer customer = null;
=======
            Customer customer = null;
            using (var ctx = new HPlusSportDbContext())
            {
>>>>>>> 6976662a5ab6e3db8a0d4789396607527501b474
                var user = ctx.Users.FirstOrDefault(u => u.EmailAddress == User.Identity.Name);

                if (user != null)
                {
                    customer = ctx.Customers.FirstOrDefault(c => c.CustomerID == user.CustomerId);
                }
<<<<<<< HEAD
                return View(customer);
            }
=======
            }
            return View(customer);
>>>>>>> 6976662a5ab6e3db8a0d4789396607527501b474
        }
    }
}