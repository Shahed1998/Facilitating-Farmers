using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Course> CourseDataAccess()
        {
            return new CourseRepo();
        }

        public static IRepo<Difficulty> DifficultyDataAccess()
        {
            return new DifficultyRepo();
        }

        public static IRepo<Category> CategoryDataAccess()
        {
            return new CategoryRepo();
        }

        public static IRepo<Admin> AdminDataAccess()
        {
            return new AdminRepo();
        }

        public static IRepo<AdminSendMessage> AdminSendMessageDataAccess()
        {
            return new AdminSendMessageRepo();
        }

    }
}
