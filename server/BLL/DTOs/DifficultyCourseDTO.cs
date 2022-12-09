using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DifficultyCourseDTO : Difficulty
    {
        public List<CourseDTO> CourseDTOs { get; set; }
        
        public DifficultyCourseDTO()
        {
            CourseDTOs = new List<CourseDTO>();
        }
    }
}
