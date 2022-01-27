using HPlus.Ecommerce.Data.Entities;
using HPlus_App.Data;
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
            Customer customer = null;
            using (var ctx = new HPlusSportDbContext())
            {
                var user = ctx.Users.FirstOrDefault(u => u.EmailAddress == User.Identity.Name);

                if (user != null)
                {
                    customer = ctx.Customers.FirstOrDefault(c => c.CustomerID == user.CustomerId);
                }
            }
            return View(customer);
        }
    }
}