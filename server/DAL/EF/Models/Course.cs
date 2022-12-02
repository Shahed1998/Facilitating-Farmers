using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Subtitle{ get; set; }

        [Required]
        [StringLength (256)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTime LastUpdatedAt { get; set; }

        [Required]
        public int DifficultyId { get; set; }

        [Required]
        public int InstructorId { get; set; }

        [Required]
        public int CategoryId { get; set; }

    }
}
