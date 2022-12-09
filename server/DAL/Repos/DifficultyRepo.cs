using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DifficultyRepo : Repo, IRepo<Difficulty>
    {
        public Difficulty Add(Difficulty obj)
        {
            throw new NotImplementedException();
        }

        public Difficulty Delete(int id)
        { 
            throw new NotImplementedException();
        }

        public List<Difficulty> Get()
        {
            return db.Difficulties.ToList();
        }

        public Difficulty Get(int id)
        {
            return db.Difficulties.Find(id);
        }

        public Difficulty Update(Difficulty obj)
        {
            throw new NotImplementedException();
        }
    }
}
