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
        public static List<CourseDTO> Get()
        {
            var data = DataAccessFactory.GetAllCourses().Get();

            var config = new MapperConfiguration(cfg => { 
                cfg.CreateMap<Course, CourseDTO>();
                cfg.CreateMap<Difficulty, DifficultyDTO>();
            });

            var mapper = new Mapper(config);

            var rt = mapper.Map<List<CourseDTO>>(data);

            return rt;
        }
    }
}
