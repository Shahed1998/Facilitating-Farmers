using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CourseServices
    {
        // Get all courses
        public static List<CourseSummaryDTO> Get()
        {
            var data = DataAccessFactory.GetAllCourses().Get();

            var config = new MapperConfiguration(cfg => { 
                cfg.CreateMap<Course, CourseSummaryDTO>();
                cfg.CreateMap<Difficulty, DifficultyDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<List<CourseSummaryDTO>>(data);

        }

        // Get course by Id
        public static CourseSummaryDTO Get(int Id)
        {
            var data = DataAccessFactory.GetAllCourses().Get(Id);

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Course, CourseSummaryDTO>();
                cfg.CreateMap<Difficulty, DifficultyDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<CourseSummaryDTO>(data);

        }
    }
}
