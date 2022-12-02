using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class FacilitatingFarmerContext : DbContext
    {
        public DbSet <Role> roles { get; set; }

        public DbSet <User> users { get; set; }

        public DbSet <Course> courses { get; set; }

        public DbSet <CourseEnrollment> courseEnrollments { get; set; }

    }
}
