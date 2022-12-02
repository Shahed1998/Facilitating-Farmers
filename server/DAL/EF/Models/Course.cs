using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("Difficulty")]
        public int DifficultyId { get; set; }
        public virtual CourseDifficulty Difficulty { get; set; }

        [Required]
        [ForeignKey("User")]
        public int InstructorId { get; set; }
        public virtual Specialist User { get; set; }

        [Required]
        [ForeignKey("CourseCategory")]
        public int CategoryId { get; set; }
        public virtual CourseCategory CourseCategory { get; set; }

        public List<CourseEnrollment> courseEnrollments { get; set; }

        public Course()
        {
            courseEnrollments = new List<CourseEnrollment>();
        }

    }
}
