using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SpecialistRepo : Repo, IRepo<Specialist>
    {
        public Specialist Add(Specialist obj)
        {
            db.Specialists.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;

        }

        public Specialist Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Specialist> Get()
        {
            return db.Specialists.ToList();
        }

        public Specialist Get(int Id)
        {
            return db.Specialists.Find(Id);
        }

        public Specialist Update(Specialist obj)
        {
            throw new NotImplementedException();
        }
    }
}
