using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.Seedwork;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;

namespace Application.MainBoundedContext.Services
{
    public class DgtAppService : IDgtAppService
    {
        #region Members

        private readonly IBrandRepository _brandRepository;

        #endregion



        #region Constructor

        /// <summary>
        ///  Create a new instance of DgtAppService
        /// </summary>
        public DgtAppService(IBrandRepository brandRepository)
        {
            //Check dependencies
            if (brandRepository == null)
                throw new ArgumentNullException("brandRepository");

            // Assign dependencies
            _brandRepository = brandRepository;
        }

        #endregion


        #region IDgtAppService implementation

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public List<BrandDTO> GetAllBrands()
        {
            // Query criteria
           IEnumerable<Brand> brands = _brandRepository.GetAll();
            if (brands != null && brands.Any())
                return brands.ProjectedAsCollection<BrandDTO>();
            else
                return null;
        }

        #endregion



        #region IDisposable implementation

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
