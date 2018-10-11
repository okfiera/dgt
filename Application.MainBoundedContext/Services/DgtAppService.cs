using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using Application.MainBoundedContext.DTO.DgtModule.Vehicles;
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
                return brands.OrderBy(m => m.Name).ProjectedAsCollection<BrandDTO>();
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




        #region Vehicle methods

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public VehicleDTO GetVehicleById(Guid id)
        {
            var result = _vehicleRepository.Get(id);
            if (result != null)
                return result.ProjectedAs<VehicleDTO>();
            else
                return null;
        }

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public VehicleDTO GetVehicleByLicense(string license)
        {
            if (String.IsNullOrEmpty(license))
                throw new ArgumentNullException("license");

            var licenseSpec = VehicleSpecifications.WithLicense(license);
            var result = _vehicleRepository.AllMatching(licenseSpec);
            if (result != null && result.Any())
                return result.First().ProjectedAs<VehicleDTO>();
            else
                return null;
        }

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public VehicleDTO AddNewVehicle(VehicleDTO vehicleDTO)
        {
            if (vehicleDTO == null)
                throw new ArgumentNullException("vehicleDTO");

            // Check vehicle license is unique
            var licenseSpec = VehicleSpecifications.WithLicense(vehicleDTO.License);
            var repeatedLicenseVehicle = _vehicleRepository.AllMatching(licenseSpec);
            if (repeatedLicenseVehicle != null && repeatedLicenseVehicle.Any())
                throw new InvalidOperationException(String.Format(CommonMessages.exception_ItemAlreadyExistsWithProperty, Names.Vehicle, Names.License, vehicleDTO.License));

            // Cast dto to vehicle and save
            var vehicle = MaterializeVehicleFromDto(vehicleDTO);

            vehicle.GenerateNewIdentity();
            vehicle.Validate();
            _vehicleRepository.Add(vehicle);
            _vehicleRepository.UnitOfWork.Commit();



            // Add habitual driver
            var driver = _driverRepository.Get(vehicleDTO.DriverId);
            if (driver == null)
                throw new InvalidOperationException(String.Format(CommonMessages.exception_EntityWithIdNotExists,
                    Names.Driver, vehicleDTO.DriverId));

            // Add VehicleDriver item
            var vehicleDriver = new VehicleDriver {DriverId = driver.Id, VehicleId = vehicle.Id};
            vehicleDriver.GenerateNewIdentity();
            _vehicleDriverRepository.Add(vehicleDriver);

            
            vehicleDriver.Validate();

            _vehicleDriverRepository.UnitOfWork.Commit();

            return vehicle.ProjectedAs<VehicleDTO>();
        }


        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public List<VehicleDTO> SearchVehicles(string filter)
        {
            if (String.IsNullOrEmpty(filter))
                throw new ArgumentNullException("filter");

            var fulltextSpec = VehicleSpecifications.FullText(filter);
            var result = _vehicleRepository.AllMatching(fulltextSpec);
            if (result != null && result.Any())
                return result.ProjectedAsCollection<VehicleDTO>();
            else
                return null;
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

        private Vehicle MaterializeVehicleFromDto(VehicleDTO dto)
        {
            var vehicle = VehicleFactory.CreateVehicle(dto.License, dto.BrandId, dto.Model);

            if (dto.Id != Guid.Empty)
                vehicle.ChangeCurrentIdentity(dto.Id);

            return vehicle;
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
