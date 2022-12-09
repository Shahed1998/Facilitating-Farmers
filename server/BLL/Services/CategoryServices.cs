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
    public class CategoryServices
    {
        // Get all categories
        public static List<CategoryDTO> Get()
        {
            var data = DataAccessFactory.GetAllCategories().Get();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryDTO>();

            });

            var mapper = new Mapper(config);

            return mapper.Map<List<CategoryDTO>>(data);
        }

        // Get category by id
        public static CategoryCourseDTO Get(int Id)
        {
            var data = DataAccessFactory.GetCategoryById().Get(Id);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryCourseDTO>();
                cfg.CreateMap<Course, CourseDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<CategoryCourseDTO>(data);
        }
    }
}
