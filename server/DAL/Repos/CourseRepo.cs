using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CourseRepo : Repo, IRepo<Course>
    {
        public Course Add(Course obj)
        {
            db.Courses.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public Course Delete(int id)
        {
            var courseObj = Get(id);

            db.Courses.Remove(courseObj);

            if (db.SaveChanges() > 0) return courseObj;

            return null;
        }

        public List<Course> Get()
        {
            return db.Courses.ToList();
        }

        public Course Get(int id)
        {
            return db.Courses.Find(id);
        }

        public Course Update(Course obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }
    }

}
