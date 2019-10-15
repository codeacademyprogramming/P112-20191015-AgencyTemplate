using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgencyTemplate.DAL;
using AgencyTemplate.Helpers;
using AgencyTemplate.Models;

namespace AgencyTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AgencyContext context = new AgencyContext();
            HomeViewModel model = new HomeViewModel
            {
                Abouts = context.Abouts.OrderBy(a => a.StartDate).Where(q => q.Status == true).ToList(),
                Employees = context.Employees.OrderBy(e => e.Ordering).Where(q => q.Status == true).ToList(),
                Partners = context.Partners.OrderBy(p => p.Ordering).Where(q => q.Status == true).ToList(),
                Portfolios = context.Portfolios.Include("Category").Where(q => q.Status == true).ToList(),
                Services = context.Services.Where(q => q.Status == true).ToList()
            };

            ViewBag.Portfolios = model.Portfolios;

            return View(model);
        }

    }
}