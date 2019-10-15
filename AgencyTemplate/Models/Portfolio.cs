using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgencyTemplate.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string SmallTitle { get; set; }
        public string Photo { get; set; }
        public string BigPhoto { get; set; }

        [AllowHtml]
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public string Client { get; set; }
        public int CategoryId { get; set; }
        public Category Category{ get; set; }

        public bool Status { get; set; }
    }
}