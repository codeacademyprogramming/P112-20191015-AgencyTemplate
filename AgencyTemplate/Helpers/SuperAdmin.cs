using AgencyTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgencyTemplate.Helpers
{
    public class SuperAdmin : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Account account =  HttpContext.Current.Session["Account"] as Account;

            if (account.Level != 0)
            {
                HttpContext.Current.Session["AccountLevelError"] = "Sizin bu sehifeye girmeye icazeniz yoxdur";
                filterContext.Result = new RedirectResult("~/Control/Home/Index");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}