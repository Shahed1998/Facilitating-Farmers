using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CategoryRepo : Repo, IRepo<Category>
    {
        public Category Add(Category obj)
        {
            throw new NotImplementedException();
        }

        public Category Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public Category Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
