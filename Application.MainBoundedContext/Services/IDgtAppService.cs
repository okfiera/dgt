using Application.MainBoundedContext.DTO.DgtModule.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MainBoundedContext.Services
{
    public interface IDgtAppService: IDisposable
    {
        /// <summary>
        /// Get all Brands
        /// </summary>
        /// <returns>List of Brand representations</returns>
        List<BrandDTO> GetAllBrands();
    }
}
