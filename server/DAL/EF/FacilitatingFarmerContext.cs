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

        public DbSet <Customer> customers { get; set; }

        public DbSet <Specialist> specialists { get; set; }

        public DbSet <Course> courses { get; set; }

        public DbSet <CourseInstructorMap> coursesInstructors { get; set; }

        public DbSet <Difficulty> difficulties { get; set; }

        public DbSet<Category> categories { get; set; }

        public DbSet <CourseVideo> courseVideos { get; set; }

        public DbSet <CouseVideoLock> couseVideoLocks { get; set; }

        public DbSet <CourseEnrollment> courseEnrollments { get; set; }

        public DbSet <Rating> ratings { get; set; }

        public DbSet <Question> questions { get; set; }

        public DbSet <Answer> answers { get; set; }

        //public DbSet <QuestionAnswerMap> questionAnswerMaps { get; set; }

    }
}
