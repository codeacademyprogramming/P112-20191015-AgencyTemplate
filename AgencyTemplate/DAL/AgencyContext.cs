using AgencyTemplate.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgencyTemplate.DAL
{
    public class AgencyContext : DbContext
    {
        public AgencyContext() :base("MenimConnectionStringim")
        {
        }


        public DbSet<Account> Accounts { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}