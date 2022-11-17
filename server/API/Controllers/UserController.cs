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
        // GET: All Users
        [HttpGet]
        [Route("api/users/all")]
        public HttpResponseMessage GetAllUsers()
        {
            var users = UserServices.Get();

            if (users == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound,
                    new { status = "Failed", message = "User not found" });
            }

            return Request.CreateResponse(HttpStatusCode.OK, new { status = "Success", users });
        }

    }

}
