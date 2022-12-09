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
        public static IRepo<Course> GetAllCourses()
        {
            return new CourseRepo();
        }

        public static IRepo<Difficulty> GetAllDifficulties()
        {
            return new DifficultyRepo();
        }

        public static IRepo<Difficulty> GetDifficultyById()
        {
            return new DifficultyRepo();
        }
    }
}
