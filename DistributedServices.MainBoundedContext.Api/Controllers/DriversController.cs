using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.MainBoundedContext.Services;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;

namespace DistributedServices.MainBoundedContext.Api.Controllers
{
    public class DriversController : ApiController
    {
        #region Members

        private readonly IDgtAppService _dgtAppService;

        #endregion



        #region Constructor

        public DriversController(IDgtAppService dgtAppService)
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
        [Route("api/drivers/{id}")]
        public IHttpActionResult Get(Guid id)
        {
            var driverDTO = this._dgtAppService.GetDriverById(id);
            return Ok(driverDTO);
        }

        [HttpGet]
        [Route("api/drivers/nif/{nif}")]
        public IHttpActionResult Nif(string nif)
        {
            var driverDTO = this._dgtAppService.GetDriverByNifNie(nif);
            return Ok(driverDTO);
        }

        [HttpGet]
        [Route("api/drivers/search/{filter}")]
        public IHttpActionResult Search(string filter)
        {
            var driverDTO = this._dgtAppService.SearchDrivers(filter);
            return Ok(driverDTO);
        }

        [HttpPost]
        [Route("api/drivers/save")]
        public IHttpActionResult Save(DriverDTO dto)
        {
            try
            {
                var result = this._dgtAppService.AddNewDriver(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
