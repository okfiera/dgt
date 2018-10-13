using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.MainBoundedContext.DTO.DgtModule.Infractions;
using Application.MainBoundedContext.Services;

namespace DistributedServices.MainBoundedContext.Api.Controllers
{
    public class InfractionsController : ApiController
    {
        #region Members

        private readonly IDgtAppService _dgtAppService;

        #endregion


        #region Constructor

        public InfractionsController(IDgtAppService dgtAppService)
        {
            //Check dependencies
            if (dgtAppService == null)
                throw new ArgumentNullException("dgtAppService");

            //Assign dependencies
            this._dgtAppService = dgtAppService;
        }

        #endregion



        #region Api methods

        [HttpPost]
        [Route("api/infractions/save")]
        public IHttpActionResult Save(InfractionDTO dto)
        {
            try
            {
                var result = this._dgtAppService.AddNewInfraction(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/infractions/driver/{driverIdentifier}")]
        public IHttpActionResult GetInfractionsByDriver(string driverIdentifier)
        {
            try
            {
                var results = _dgtAppService.SearchInfractions("", driverIdentifier, null, null, null);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/infractions/last/{count}")]
        public IHttpActionResult GetLastInfractions(int count = 15)
        {
            try
            {
                var results = _dgtAppService.GetLastInfractions(count);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/infractions/vehicle/{vehicleLicense}")]
        public IHttpActionResult GetInfractionsByLicense(string vehicleLicense)
        {
            try
            {
                var results = _dgtAppService.SearchInfractions(vehicleLicense, "", null, null, null);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/infractions/stats")]
        public IHttpActionResult GetInfractionStats()
        {
            try
            {
                var results = _dgtAppService.GetInfractionStats();
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpGet]
        [Route("api/infractions/search/")]
        public IHttpActionResult Search()
        {
            try
            {
                var queries = this.Request.GetQueryNameValuePairs().ToDictionary(p => p.Key, p => p.Value);

                var vehicleLicense = "";
                var driverIdentifier = "";
                Guid? infractionTypeId = null;
                DateTime? from = null;
                DateTime? to = null;

                foreach (var query in queries)
                {
                    if (query.Key.ToLower() == "vehiclelicense")
                        vehicleLicense = query.Value;

                    if (query.Key.ToLower() == "driveridentifier")
                        driverIdentifier = query.Value;

                    if (query.Key.ToLower() == "infractiontypeid")
                        infractionTypeId = new Guid(query.Value);

                    if (query.Key.ToLower() == "from")
                        from = DateTime.ParseExact(query.Value, "yyyy-MM-dd",
                            System.Globalization.CultureInfo.InvariantCulture);

                    if (query.Key.ToLower() == "to")
                        to = DateTime.ParseExact(query.Value, "yyyy-MM-dd",
                            System.Globalization.CultureInfo.InvariantCulture);
                }

                var results = _dgtAppService.SearchInfractions(vehicleLicense, driverIdentifier, infractionTypeId, from, to);

                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        #endregion
    }
}
