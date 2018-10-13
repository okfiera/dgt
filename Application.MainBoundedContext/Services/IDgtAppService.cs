using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;
using Application.MainBoundedContext.DTO.DgtModule.Vehicles;
using Application.MainBoundedContext.DTO.DgtModule.Infractions;
using Application.MainBoundedContext.DTO.DgtModule.VehiclesDrivers;

namespace Application.MainBoundedContext.Services
{
    public interface IDgtAppService: IDisposable
    {
        #region Brands

        /// <summary>
        /// Get all Brands
        /// </summary>
        /// <returns>List of Brand representations</returns>
        List<BrandDTO> GetAllBrands();

        /// <summary>
        /// Get Brand by identifier
        /// </summary>
        /// <param name="id">Brand identifier</param>
        /// <returns></returns>
        BrandDTO GetBrandById(Guid id);

        #endregion


        //-----------------------------------------------------------------------


        #region Infraction types

        /// <summary>
        /// Get all Infraction types
        /// </summary>
        /// <returns>List of infraction type representations</returns>
        List<InfractionTypeDTO> GetAllInfractionTypes();


        /// <summary>
        /// Add new Infraction type
        /// </summary>
        /// <param name="infractionType">Infraction type to create</param>
        /// <returns>Infraction type representation created</returns>
        InfractionTypeDTO AddNewInfractionType(InfractionTypeDTO infractionType);

        #endregion


        //-----------------------------------------------------------------------


        #region Drivers

        /// <summary>
        /// Search drivers by text filter
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <returns>Returns drivers representations that match</returns>
        List<DriverDTO> SearchDrivers(string filter);

        /// <summary>
        /// Get driver by Id
        /// </summary>
        /// <param name="id">Driver id</param>
        /// <returns>Driver representation that match</returns>
        DriverDTO GetDriverById(Guid id);

        /// <summary>
        /// Get driver by NIF, NIE, ...
        /// </summary>
        /// <param name="identifier">NIF, NIE, ...</param>
        /// <returns>Driver representation that match</returns>
        DriverDTO GetDriverByNifNie(string identifier);

        /// <summary>
        /// Attach driver to vehicle
        /// </summary>
        /// <param name="vehicleLicense">Vehicle license plate</param>
        /// <param name="driverIdentifier">Driver identifier</param>
        /// <returns></returns>
        VehicleDriverDTO AttachDriverToVehicle(string vehicleLicense, string driverIdentifier);

        /// <summary>
        /// Add new Driver
        /// </summary>
        /// <param name="driver">Driver to add</param>
        /// <returns>Driver representation created</returns>
        DriverDTO AddNewDriver(DriverDTO driver);

        #endregion


        //-----------------------------------------------------------------------


        #region Vehicles

        /// <summary>
        /// Get vehicle by Id
        /// </summary>
        /// <param name="id">Vehicle id</param>
        /// <returns>Vehicle representation that match</returns>
        VehicleDTO GetVehicleById(Guid id);

        /// <summary>
        /// Get vehicle by license
        /// </summary>
        /// <param name="license">Vehicle license plate</param>
        /// <returns>Vehicle representation that match</returns>
        VehicleDTO GetVehicleByLicense(string license);

        /// <summary>
        /// Add new Vehicle
        /// </summary>
        /// <param name="vehicle">Vehicle to add</param>
        /// <returns>Vehicle representation created</returns>
        VehicleDTO AddNewVehicle(VehicleDTO vehicle);

        /// <summary>
        /// Search vehicles
        /// </summary>
        /// <param name="filter">Filter to search</param>
        /// <returns>Vehicle representation</returns>
        List<VehicleDTO> SearchVehicles(string filter);

        #endregion


        //-----------------------------------------------------------------------


        #region Infractions

        /// <summary>
        /// Add new Infraction
        /// </summary>
        /// <param name="dto">Infraction representation to create</param>
        /// <returns>Infraction representation created</returns>
        InfractionDTO AddNewInfraction(InfractionDTO dto);

        /// <summary>
        /// Search infractions
        /// </summary>
        /// <param name="vehicleLicense">Vehicle license plate filter</param>
        /// <param name="driverIdentifier">Driver NIF / NIE</param>
        /// <param name="infractionTypeId">Infraction type filter</param>
        /// <param name="from">Infraction from date filter</param>
        /// <param name="to">Infraction to date filter</param>
        /// <returns>Infractions representations that match</returns>
        List<InfractionDTO> SearchInfractions(string vehicleLicense, string driverIdentifier, Guid? infractionTypeId, DateTime? from, DateTime? to);

        /// <summary>
        /// Get last number of infractions
        /// </summary>
        /// <param name="count">Number of elements to show</param>
        /// <returns>Infraction representations</returns>
        List<InfractionDTO> GetLastInfractions(int count);

        /// <summary>
        /// Get infraction stats
        /// </summary>
        /// <returns>Infraction stats representation</returns>
        List<InfractionStatsDTO> GetInfractionStats();

        #endregion



        #region VehicleDriver

        /// <summary>
        /// Get Vehicles by driver identifier
        /// </summary>
        /// <param name="driverIdentifier">Driver NIF, NIE</param>
        /// <returns></returns>
        List<VehicleDriverDTO> GetVehiclesByDriver(string driverIdentifier);

        /// <summary>
        /// Get Drivers by vehicle license
        /// </summary>
        /// <param name="vehicleLicense">Vehicle license</param>
        /// <returns></returns>
        List<VehicleDriverDTO> GetDriversByVehicle(string vehicleLicense);

        #endregion





    }
}
