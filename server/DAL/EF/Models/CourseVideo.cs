using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class CourseVideo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CourseId { get; set; }


        [Required]
        public string Video { get; set; }
    }
}
