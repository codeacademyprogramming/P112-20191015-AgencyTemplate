using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgencyTemplate.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(200)]
        public string Password { get; set; }

        public string Photo { get; set; }

        [MaxLength(200)]
        public string Fullname { get; set; }

        public int Level { get; set; }

        public bool Status { get; set; }
    }
}