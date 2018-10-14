using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.MainBoundedContext.Services;
using Application.MainBoundedContext.DTO.DgtModule.Vehicles;

namespace DistributedServices.MainBoundedContext.Api.Controllers
{
    public class VehicleController : ApiController
    {
        #region Members

        private readonly IDgtAppService _dgtAppService;
        public const string GuidPattern = @"^[A-Za-z0-9]{8}-[A-Za-z0-9]{4}-[A-Za-z0-9]{4}-[A-Za-z0-9]{4}-[A-Za-z0-9]{12}$";

        #endregion



        #region Constructor


        public VehicleController(IDgtAppService dgtAppService)
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
        [Route("api/vehicles/{id:guid}")]
        public IHttpActionResult Get(Guid id)
        {
            var vehicleDTO = this._dgtAppService.GetVehicleById(id);
            return Ok(vehicleDTO);
        }

        [HttpGet]
        [Route("api/vehicles/all")]
        public IHttpActionResult All()
        {
            var vehicleDTO = this._dgtAppService.GetAllVehicles();
            return Ok(vehicleDTO);
        }

        [HttpGet]
        [Route("api/vehicles/search/{filter}")]
        public IHttpActionResult Search(string filter)
        {
            var vehicleDTO = this._dgtAppService.SearchVehicles(filter);
            return Ok(vehicleDTO);
        }

        [HttpGet]
        [Route("api/vehicles/license/{license}")]
        public IHttpActionResult Nif(string license)
        {
            var vehicleDTO = this._dgtAppService.GetVehicleByLicense(license);
            return Ok(vehicleDTO);
        }

        [HttpGet]
        [Route("api/vehicles/driver/{identifier}")]
        public IHttpActionResult GetVehicleDrivers(string identifier)
        {
            var vehicleDTO = this._dgtAppService.GetVehiclesByDriver(identifier);
            return Ok(vehicleDTO);
        }

        [HttpPost]
        [Route("api/vehicles/save")]
        public IHttpActionResult Save(VehicleDTO dto)
        {
            try
            {
                var result = this._dgtAppService.AddNewVehicle(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("api/vehicles-drivers/{vehicleLicense}/{driverIdentifier}")]
        public IHttpActionResult AttachDriverToVehicle(string vehicleLicense, string driverIdentifier)
        {
            try
            {
                var vehicleDTO = this._dgtAppService.AttachDriverToVehicle(vehicleLicense, driverIdentifier);
                return Ok(vehicleDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
