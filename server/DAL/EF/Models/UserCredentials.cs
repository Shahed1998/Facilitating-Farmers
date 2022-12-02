using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class UserCredentials
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(128), MinLength(8)]
        public string Password { get; set; }

        public List<Customer> Customer { get; set; }
        public List<Specialist> Specialist { get; set; }

        public List<Admin> Admin { get; set; }

        public UserCredentials()
        {
            Customer = new List<Customer>();
            Specialist = new List<Specialist>();
            Admin = new List<Admin>();
        }
    }
}
