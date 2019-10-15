using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgencyTemplate.Models
{
    public class HomeViewModel
    {
        public List<About> Abouts { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Partner> Partners { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<Service> Services { get; set; }
    }
}