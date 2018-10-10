using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
