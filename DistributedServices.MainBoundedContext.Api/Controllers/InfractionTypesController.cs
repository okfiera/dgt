using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.MainBoundedContext.Services;

namespace DistributedServices.MainBoundedContext.Api.Controllers
{
    public class InfractionTypesController : ApiController
    {

        #region Members

        private readonly IDgtAppService _dgtAppService;

        #endregion



        #region Constructor

        public InfractionTypesController(IDgtAppService dgtAppService)
        {
            //Check dependencies
            if (dgtAppService == null)
                throw new ArgumentNullException("dgtAppService");

            //Assign dependencies
            this._dgtAppService = dgtAppService;
        }

        #endregion



        #region Api methods

        [HttpGet]
        public IHttpActionResult Get()
        {
            var infractionTypesDTO = this._dgtAppService.GetAllInfractionTypes();
            return Ok(infractionTypesDTO);
        }

        #endregion
    }
}
