using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AgencyTemplate.Models
{

    public class About
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Column(TypeName = "date")]

        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]

        public DateTime? EndDate { get; set; }
        public string Photo { get; set; }

        public bool Status { get; set; }
    }
}