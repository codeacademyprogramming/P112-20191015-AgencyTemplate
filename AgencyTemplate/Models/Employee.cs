using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgencyTemplate.Models
{
    public class Employee
    {
        public int  Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public string Photo { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }

        public int Ordering { get; set; }

        public bool Status { get; set; }

    }
}