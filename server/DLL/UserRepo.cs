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
        // Get all users
        public static List<User> Get()
        {
            var db = new Facilitating_FarmersEntities1();
            return db.Users.ToList();
        }

        // Login user
        public static User Get(string Email, string Password)
        {
         
            var db = new Facilitating_FarmersEntities1();

            var user = db.Users.FirstOrDefault(x => x.Email == Email);

            if (user != null && user.Password == Password)
            {
                return user;
            }

            return null;
        }


    }
}
