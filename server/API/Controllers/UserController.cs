using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using BLL;


namespace API.Controllers
{
    public class UserController : ApiController
    {
        // GET: User
        [HttpGet]
        [Route("api/users/all")]
        public HttpResponseMessage GetAllUsers()
        {
            var users = UserServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, users);
        }
    }
}