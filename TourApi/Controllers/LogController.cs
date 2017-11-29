using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TourApi.Controllers
{
    public class LogController : ApiController
    {
        [HttpPost]
        [Route ("api/v1/post")]
        public HttpResponseMessage Post(string User)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
}
