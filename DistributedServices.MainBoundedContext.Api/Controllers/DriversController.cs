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
        [Route("api/drivers/identifier/{identifier}")]
        public IHttpActionResult Nif(string identifier)
        {
            var driverDTO = this._dgtAppService.GetDriverByNifNie(identifier);
            return Ok(driverDTO);
        }

        [HttpGet]
        [Route("api/drivers/search/{filter}")]
        public IHttpActionResult Search(string filter)
        {
            var driverDTO = this._dgtAppService.SearchDrivers(filter);
            return Ok(driverDTO);
        }

        [HttpGet]
        [Route("api/drivers/vehicle/{license}")]
        public IHttpActionResult GetVehicleDrivers(string license)
        {
            var vehiclesDTO = this._dgtAppService.GetDriversByVehicle(license);
            return Ok(vehiclesDTO);
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
