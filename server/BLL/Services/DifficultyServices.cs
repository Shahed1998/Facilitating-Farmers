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
    public static class DifficultyServices
    {
        // Get all difficulties
        public static List<DifficultyDTO> Get()
        {
            var difficulties = DataAccessFactory.GetAllDifficulties().Get();

            var config = new MapperConfiguration(cfg => { 

                cfg.CreateMap<Difficulty, DifficultyDTO>();

            });

            var mapper = new Mapper(config);

            return mapper.Map<List<DifficultyDTO>>(difficulties);

        }

        // Get difficulty with id
        public static DifficultyCourseDTO GetWithCourses(int id)
        {
            var data = DataAccessFactory.GetDifficultyById().Get(id);

            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<Difficulty, DifficultyCourseDTO>();
                cfg.CreateMap<Course, CourseDTO>();
               
            });

            var mapper = new Mapper(config);

            return mapper.Map<DifficultyCourseDTO>(data);

        }
    }
}
