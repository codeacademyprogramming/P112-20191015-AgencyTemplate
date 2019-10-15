using AgencyTemplate.DAL;
using AgencyTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AgencyTemplate.Areas.Control.Controllers
{
    public class AccountController : Controller
    {
        AgencyContext context = new AgencyContext();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account account)
        {
            if (string.IsNullOrEmpty(account.Email) || 
                string.IsNullOrEmpty(account.Password))
            {
                Session["LoginError"] = "Email veya Password bosh qoyula bilmez";
                return View();
            }

             Account admin = context.Accounts.FirstOrDefault(a => a.Email == account.Email);
            if (admin == null)
            {
                Session["LoginError"] = "Bu hesab movcud deyil";
                return View();
            }

            bool isMatch = Crypto.VerifyHashedPassword(admin.Password, account.Password);

            if (!isMatch)
            {
                Session["LoginError"] = "Email veya password yanlishdir";
                return View();
            }
            
            Session["LoginOlunubmu"] = true;
            Session["Account"] = admin;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Test()
        {
            string hashed = Crypto.HashPassword("admin123");
            return Content(hashed);
        }

    }
}