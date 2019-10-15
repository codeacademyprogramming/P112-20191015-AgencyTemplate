using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgencyTemplate.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Icon { get; set; }

        public bool Status { get; set; }

    }
}