using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using Application.Seedwork;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleDriverAgg;
using Infrastructure.GlobalResources;

namespace Application.MainBoundedContext.Services
{
    public class DgtAppService : IDgtAppService
    {
        #region Members

        private const int INITIAL_POINTS = 12;

        private readonly IBrandRepository _brandRepository;
        private readonly IInfractionTypeRepository _infractionTypeRepository;
        private readonly IDriverRepository _driverRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IVehicleDriverRepository _vehicleDriverRepository;
        private readonly IInfractionRepository _infractionRepository;

        #endregion



        #region Constructor

        /// <summary>
        ///  Create a new instance of DgtAppService
        /// </summary>
        public DgtAppService(
            IBrandRepository brandRepository, 
            IInfractionTypeRepository infractionTypeRepository,
            IDriverRepository driverRepository,
            IVehicleRepository vehicleRepository,
            IInfractionRepository infractionRepository,
            IVehicleDriverRepository vehicleDriverRepository)
        {
            //Check dependencies
            if (brandRepository == null)
                throw new ArgumentNullException("brandRepository");

            if (infractionTypeRepository == null)
                throw new ArgumentNullException("infractionTypeRepository");

            if (driverRepository == null)
                throw new ArgumentNullException("driverRepository");

            if (vehicleRepository == null)
                throw new ArgumentNullException("vehicleRepository");

            if (infractionRepository == null)
                throw new ArgumentNullException("infractionRepository");

            if (vehicleDriverRepository == null)
                throw new ArgumentNullException("vehicleDriverRepository");

            // Assign dependencies
            _brandRepository = brandRepository;
            _infractionTypeRepository = infractionTypeRepository;
            _driverRepository = driverRepository;
            _vehicleRepository = vehicleRepository;
            _infractionRepository = infractionRepository;
            _vehicleDriverRepository = vehicleDriverRepository;
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

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public BrandDTO GetBrandById(Guid id)
        {
            var result = _brandRepository.Get(id);
            if (result != null)
                return result.ProjectedAs<BrandDTO>();
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
                throw new ArgumentNullException("infractionTypeDTO");

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



        #region Driver methods

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public List<DriverDTO> SearchDrivers(string filter)
        {
            if (String.IsNullOrEmpty(filter))
                throw new ArgumentNullException("filter");

            var fulltextSpec = DriverSpecifications.FullText(filter);
            var result = _driverRepository.AllMatching(fulltextSpec);
            if (result != null && result.Any())
                return result.ProjectedAsCollection<DriverDTO>();
            else
                return null;
        }

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public DriverDTO GetDriverById(Guid id)
        {
            var result = _driverRepository.Get(id);
            if (result != null)
                return result.ProjectedAs<DriverDTO>();
            else
                return null;
        }

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public DriverDTO GetDriverByNifNie(string identifier)
        {
            if (String.IsNullOrEmpty(identifier))
                throw new ArgumentNullException("identifier");

            var identifierSpec = DriverSpecifications.WithIdentifier(identifier);
            var result = _driverRepository.AllMatching(identifierSpec);
            if (result != null && result.Any())
                return result.First().ProjectedAs<DriverDTO>();
            else
                return null;
        }

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public DriverDTO AddNewDriver(DriverDTO driverDTO)
        {
            if (driverDTO == null)
                throw new ArgumentNullException("driverDTO");

            // Check driver identifier is unique
            var identifierSpec = DriverSpecifications.WithIdentifier(driverDTO.Identifier);
            var repeatedIdentifierDriver = _driverRepository.AllMatching(identifierSpec);
            if(repeatedIdentifierDriver != null && repeatedIdentifierDriver.Any())
                throw new InvalidOperationException(String.Format(CommonMessages.exception_ItemAlreadyExistsWithProperty, Names.Driver, Names.Identifier, driverDTO.Identifier));

            // Cast dto to driver and save
            var driver = MaterializeDriverFromDto(driverDTO);

            // Set initial points for new drivers
            driver.SetInitialPoints();

            driver.GenerateNewIdentity();
            driver.Validate();

            _driverRepository.Add(driver);
            _driverRepository.UnitOfWork.Commit();

            return driver.ProjectedAs<DriverDTO>();
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

        private Driver MaterializeDriverFromDto(DriverDTO dto)
        {
            var driver = DriverFactory.CreateDriver(dto.Identifier, dto.FirstName, dto.LastName, dto.Points);

            if (dto.Id != Guid.Empty)
                driver.ChangeCurrentIdentity(dto.Id);

            return driver;
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
