using System;
using System.Collections.Generic;
using System.Web.Http;
using Application.MainBoundedContext.Services;

namespace DistributedServices.MainBoundedContext.Api.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("WebApi working ...");
        }
    }
}
