using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.EF;

namespace DLL
{
    public class UserRepo
    {
        public static List<User> Get()
        {
            var db = new Facilitating_FarmersEntities1();
            return db.Users.ToList();
        }
    }
}
