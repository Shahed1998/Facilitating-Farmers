using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<TClass>
    {
        TClass Add(TClass @obj);

        List<TClass> Get();

        TClass Get(int id);

        TClass Update(TClass @obj);

        TClass Delete(int id);

    }
}
