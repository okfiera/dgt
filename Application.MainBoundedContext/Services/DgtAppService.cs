using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using Application.Seedwork;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;
using Infrastructure.GlobalResources;

namespace Application.MainBoundedContext.Services
{
    public class DgtAppService : IDgtAppService
    {
        #region Members

        private readonly IBrandRepository _brandRepository;
        private readonly IInfractionTypeRepository _infractionTypeRepository;

        #endregion



        #region Constructor

        /// <summary>
        ///  Create a new instance of DgtAppService
        /// </summary>
        public DgtAppService(
            IBrandRepository brandRepository, 
            IInfractionTypeRepository infractionTypeRepository)
        {
            //Check dependencies
            if (brandRepository == null)
                throw new ArgumentNullException("brandRepository");

            if (infractionTypeRepository == null)
                throw new ArgumentNullException("infractionTypeRepository");

            // Assign dependencies
            _brandRepository = brandRepository;
            _infractionTypeRepository = infractionTypeRepository;
        }

        #endregion


        #region IDgtAppService implementation


        #region Brands methods

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



        #region Infraction types methods

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public List<InfractionTypeDTO> GetAllInfractionTypes()
        {
            IEnumerable<InfractionType> infractionTypes = _infractionTypeRepository.GetAll();
            if (infractionTypes != null && infractionTypes.Any())
                return infractionTypes.ProjectedAsCollection<InfractionTypeDTO>();
            else
                return null;
        }

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public InfractionTypeDTO AddNewInfractionType(InfractionTypeDTO infractionTypeDTO)
        {
            if (infractionTypeDTO == null)
                throw new ArgumentNullException("infractionType");

            // Check InfractionType name is not repeated
            var repeatedName = _infractionTypeRepository.GetFiltered(i => i.Name.ToLower() == infractionTypeDTO.Name.ToLower());
            if (repeatedName != null && repeatedName.Any())
                throw new InvalidOperationException(String.Format(CommonMessages.exception_ItemAlreadyExistsWithProperty, Names.InfractionType, Names.Name, infractionTypeDTO.Name));
            
            // Cast and save item
            var infractionType = MaterializeInfractionTypeFromDto(infractionTypeDTO);
            infractionType.GenerateNewIdentity();
            infractionType.Validate();

            _infractionTypeRepository.Add(infractionType);
            _infractionTypeRepository.UnitOfWork.Commit();

            return infractionType.ProjectedAs<InfractionTypeDTO>();
        }

        #endregion



        #endregion




        #region Private methods

        private InfractionType MaterializeInfractionTypeFromDto(InfractionTypeDTO dto)
        {
            var it = new InfractionType()
            {
                Name = dto.Name,
                Points = dto.Points,
                Description = dto.Description
            };

            if (dto.Id != Guid.Empty)
                it.ChangeCurrentIdentity(dto.Id);

            return it;
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
