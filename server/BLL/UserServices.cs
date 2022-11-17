using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL;

namespace BLL
{
    public class UserServices
    {
        // Return all users
        public static List<UserDTO> Get()
        {
            var users = new List<UserDTO>();

            foreach (var item in UserRepo.Get())
            {
                users.Add(new UserDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    Password = item.Password,
                    Role = item.Role
                });
            }
            
            return users;
        }

        // User login
        public static List<UserDTO> Get(LoginBody body)
        {
            var users = new List<UserDTO>();

            var item = UserRepo.Get(body.Email, body.Password);

            if (item == null) return null;

            users.Add(new UserDTO()
            {
                Id = item.Id,
                Name = item.Name,
                Email = item.Email,
                Password = item.Password,
                Role = item.Role
            });

            return users;
        }
    }
}
