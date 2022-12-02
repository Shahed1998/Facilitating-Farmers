using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [ForeignKey("UserCredentials")]
        public int CredentialId { get; set; }
        public virtual UserCredentials UserCredentials { get; set; }

        public List<CourseEnrollment> courseEnrollments { get; set; }

        public Customer()
        { 
            courseEnrollments = new List<CourseEnrollment>();
        }

    }
}
