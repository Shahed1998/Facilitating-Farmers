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
    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("api/sign-in")]
        public HttpResponseMessage SignIn([FromBody] LoginBody body)
        {

            var user = UserServices.Get(body);

            if (user == null) return Request.CreateResponse(HttpStatusCode.BadRequest, 
                new
                {
                    status = "Failed",
                    message = "User not found"
                });

            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    status = "Success",
                    users = user
                });
        }
    }
}

