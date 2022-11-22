using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo <TClass, TID, TResult>
    {
        List <TClass> Get();

        TClass Get(TID id);

        TResult Add(TClass item);

        bool Delete(TClass item);

        TResult Update(TClass item);

    }
}
