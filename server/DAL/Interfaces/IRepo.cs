using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<TClass, TDataType>
    {
        TDataType Add(TClass @obj);

        List<TClass> Get();

        TClass Get(int id);

        TDataType Update(TClass @obj);

        TDataType Delete(int id);


    }
}
