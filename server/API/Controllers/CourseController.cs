using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/course")]
    public class CourseController : ApiController
    {
        // Get all courses
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllCourses()
        {
            try
            {
                var data = CourseServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            } catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Get all difficulties
        [HttpGet]
        [Route("difficulties")]
        public HttpResponseMessage GetAllDifficulties()
        {
            try
            {
                var data = DifficultyServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Get difficulty by id
        [HttpGet]
        [Route("difficulty/{id}")]
        public HttpResponseMessage GetDifficulty(int id)
        {
            try
            {
                var data = DifficultyServices.GetWithCourses(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        
        }
    }
}
