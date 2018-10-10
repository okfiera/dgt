using System;
using System.Collections.Generic;
using System.Web.Http;
using Application.MainBoundedContext.Services;

namespace DistributedServices.MainBoundedContext.Api.Controllers
{
    public class TestController : ApiController
    {
        #region Members

        private readonly IDgtAppService _dgtAppService;

        #endregion



        #region Constructor

        public TestController(IDgtAppService dgtAppService)
        {
            //Check dependencies
            if (dgtAppService == null)
                throw new ArgumentNullException("dgtAppService");

            //Assign dependencies
            this._dgtAppService = dgtAppService;
        }
        #endregion


        [HttpGet]
        public IHttpActionResult Get()
        {
            var brandsDTO = this._dgtAppService.GetAllBrands();
            return Ok(brandsDTO);
        }
    }
}
