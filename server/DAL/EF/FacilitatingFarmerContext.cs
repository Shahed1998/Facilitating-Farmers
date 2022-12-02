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

        //public DbSet <Customer> users { get; set; }

        public DbSet <Course> courses { get; set; }

        public DbSet <CourseEnrollment> courseEnrollments { get; set; }

        public DbSet <CourseDifficulty> courseDifficulties { get; set; }

        public DbSet <CourseCategory> courseCategories { get; set; }

        public DbSet <CourseVideo> courseVideos { get; set; }

        public DbSet<Rating> ratings { get; set; }

        public DbSet<UserCredentials> userCredentials { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Specialist> Specialists { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
