using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgencyTemplate.Models
{
    public class Partner
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad boş qoyula bilməz")]
        [MaxLength(200)]
        [Display(Name = "Partnyorun adı")]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name ="Şəkil")]
        public string Photo { get; set; }

        public int Ordering { get; set; }
        public bool Status { get; set; }
    }
}