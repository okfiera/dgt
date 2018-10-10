using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;

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
        /// Add new Driver
        /// </summary>
        /// <param name="driver">Driver to add</param>
        /// <returns>Driver representation created</returns>
        DriverDTO AddNewDriver(DriverDTO driver);

        #endregion

    }
}
