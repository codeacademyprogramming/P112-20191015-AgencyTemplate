using AgencyTemplate.DAL;
using AgencyTemplate.Helpers;
using AgencyTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgencyTemplate.Areas.Control.Controllers
{
    
    public class ServiceController : Controller
    {
        AgencyContext db = new AgencyContext();

        public ActionResult Index()
        {

            return View(db.Services.ToList());
        }

        [SuperAdmin]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Service service = db.Services.FirstOrDefault(s => s.Id == id);

            if (service == null)
            {
                return HttpNotFound();
            }


            return View(service);
        }
    }
}