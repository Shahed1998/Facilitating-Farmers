using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;
using BLL.DTO;

namespace BLL
{
    public class UserServices
    {
        // Returns all the users
        public static List<UserDTO> Get()
        {
            var users = new List<UserDTO>();

            foreach(var item in UserRepo.Get())
            {
                users.Add(new UserDTO() {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    Password = item.Password,
                    Role = item.Role
                });

            }

            return users;
        }
    }
}
