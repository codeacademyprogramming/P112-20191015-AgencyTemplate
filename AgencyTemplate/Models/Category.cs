using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgencyTemplate.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Portfolio> Portfolios { get; set; }

        public bool Status { get; set; }
    }
}