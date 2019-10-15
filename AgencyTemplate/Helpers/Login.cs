using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgencyTemplate.Helpers
{
    public class Login : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (HttpContext.Current.Session["LoginOlunubmu"] == null)
            {
                filterContext.Result = new RedirectResult("~/Control/Account/Login");
                return;
            }

            base.OnActionExecuting(filterContext);
        }

    }
}