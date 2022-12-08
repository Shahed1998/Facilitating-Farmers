using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CourseRepo : Repo, IRepo<Course, bool>
    {
        public Course Add(Course obj)
        {
            db.Courses.Add(obj);

            if (db.SaveChanges() > 0) return obj;
            
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> Get()
        {
            throw new NotImplementedException();
        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Course obj)
        {
            throw new NotImplementedException();
        }
    }
}
