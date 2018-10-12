using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;
using Application.MainBoundedContext.DTO.DgtModule.Infractions;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using Application.MainBoundedContext.DTO.DgtModule.Vehicles;
using Application.MainBoundedContext.DTO.DgtModule.VehiclesDrivers;
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
                return infractionTypes.OrderBy(i => i.Name).ProjectedAsCollection<InfractionTypeDTO>();
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
        /// <param name="vehicleLicense"><see cref="IDgtAppService"/></param>
        /// <param name="driverIdentifier"><see cref="IDgtAppService"/></param>
        /// <returns></returns>
        public VehicleDriverDTO AttachDriverToVehicle(string vehicleLicense, string driverIdentifier)
        {
            // Check arguments
            if (String.IsNullOrEmpty(vehicleLicense))
                throw new ArgumentNullException(vehicleLicense);

            if (String.IsNullOrEmpty(driverIdentifier))
                throw new ArgumentNullException(driverIdentifier);

            //Get vehicle
            Vehicle vehicle;
            var vehicleResult = _vehicleRepository.GetFiltered(v => v.License.ToLower() == vehicleLicense.ToLower());
            if (vehicleResult == null || !vehicleResult.Any())
                throw new InvalidOperationException(String.Format(CommonMessages.exception_EntityWithIdNotExists,
                    Names.Vehicle, vehicleLicense));
            else
                vehicle = vehicleResult.First();

            // Get driver
            Driver driver;
            var driverResult = _driverRepository.GetFiltered(v => v.Identifier.ToLower() == driverIdentifier.ToLower());
            if (driverResult == null || !driverResult.Any())
                throw new InvalidOperationException(String.Format(CommonMessages.exception_EntityWithIdNotExists,
                    Names.Driver, driverIdentifier));
            else
                driver = driverResult.First();

            // Check driver is not assigned to vehicle
            var repeatedDriver = _vehicleDriverRepository.GetFiltered(v => v.DriverId == driver.Id && v.VehicleId == vehicle.Id);
            if(repeatedDriver != null && repeatedDriver.Any())
                throw new InvalidOperationException(String.Format(CommonMessages.exception_DriverAlreadyIsHabitualDriverOfVehicle,
                    driver.Identifier, vehicle.License));

            // Create assignation
            var vd = new VehicleDriver() {DriverId = driver.Id, VehicleId = vehicle.Id};
            vd.GenerateNewIdentity();

            // Save changes
            _vehicleDriverRepository.Add(vd);
            _vehicleDriverRepository.UnitOfWork.Commit();

            return vd.ProjectedAs<VehicleDriverDTO>();
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
            
            // Add habitual driver
            var driver = _driverRepository.Get(vehicleDTO.DriverId);
            if (driver == null)
                throw new InvalidOperationException(String.Format(CommonMessages.exception_EntityWithIdNotExists,
                    Names.Driver, vehicleDTO.DriverId));

            // Check driver vehicles
            var driverVehicles = _vehicleDriverRepository.GetFiltered(vd => vd.DriverId == driver.Id);
            if (driverVehicles.Count() > 10)
                throw new InvalidOperationException(String.Format(CommonMessages.exception_DriverMaxVehicles,
                    driver.Identifier, 10));

            // Add VehicleDriver item
            var vehicleDriver = new VehicleDriver() {VehicleId = vehicle.Id, DriverId = driver.Id};
            vehicleDriver.GenerateNewIdentity();

            // Validate items and save
            vehicle.Validate();
            vehicleDriver.Validate();

            _vehicleRepository.Add(vehicle);
            _vehicleRepository.UnitOfWork.Commit();
            _vehicleDriverRepository.Add(vehicleDriver);
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




        #region Infractions methods

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public InfractionDTO AddNewInfraction(InfractionDTO infractionDTO)
        {
            try
            {
                if (infractionDTO == null)
                    throw new ArgumentNullException("infractionDTO");

                // Get associated driver
                var driver = _driverRepository.Get(infractionDTO.DriverId);
                if (driver == null)
                    throw new InvalidOperationException(String.Format(CommonMessages.exception_EntityWithIdNotExists,
                        Names.Driver, infractionDTO.DriverId));

                //Get associated vehicle
                var vehicle = _vehicleRepository.Get(infractionDTO.VehicleId);
                if (vehicle == null)
                    throw new InvalidOperationException(String.Format(CommonMessages.exception_EntityWithIdNotExists,
                        Names.Vehicle, infractionDTO.VehicleId));

                // Check vehicle belong to driver
                var vehicleDriver =
                    _vehicleDriverRepository.GetFiltered(vd => vd.DriverId == driver.Id && vd.VehicleId == vehicle.Id);
                if (vehicleDriver == null || !vehicleDriver.Any())
                    throw new InvalidOperationException(String.Format(
                        CommonMessages.exception_VehicleDoesNowBelongToDriver,
                        vehicle.License, driver.Identifier));

                // Get associated infraction type
                var infractionType = _infractionTypeRepository.Get(infractionDTO.InfractionTypeId);
                if (infractionType == null)
                    throw new InvalidOperationException(String.Format(CommonMessages.exception_EntityWithIdNotExists,
                        Names.InfractionType, infractionDTO.InfractionTypeId));

                // Materialize infraction from dto
                var infraction = MaterializeInfractionFromDto(infractionDTO);
                infraction.Validate();
                infraction.GenerateNewIdentity();
                _infractionRepository.Add(infraction);

                // Remove points to driver
                driver.RemovePoints(infractionType.Points);

                _infractionRepository.UnitOfWork.Commit();
                _driverRepository.UnitOfWork.Commit();

                return infraction.ProjectedAs<InfractionDTO>();
            }
            catch (ApplicationValidationErrorsException valEx)
            {
                string erMsg = "";

                foreach (var item in valEx.ValidationErrors)
                    erMsg += Environment.NewLine + item;
                
                throw new Exception(erMsg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <returns><see cref="IDgtAppService"/></returns>
        public List<InfractionDTO> SearchInfractions(string vehicleLicense, string driverIdentifier, Guid? infractionTypeId, DateTime? from, DateTime? to)
        {
            var vehicleLicenseSpec = InfractionSpecifications.WithVehicleLicense(vehicleLicense);
            var driverIdentifierSpec = InfractionSpecifications.WithDriverIdentifier(driverIdentifier);
            var infractionTypeSpec = InfractionSpecifications.WithInfractionType(infractionTypeId);
            var dateSpec = InfractionSpecifications.WithDateRange(from, to);

            var specs = vehicleLicenseSpec & driverIdentifierSpec & infractionTypeSpec & dateSpec;

            var results = _infractionRepository.AllMatching(specs);
            if (results != null && results.Any())
                return results.ProjectedAsCollection<InfractionDTO>();
            else
                return null;
        }

        #endregion





        #region VehicleDriver methods

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <param name="driverIdentifier"><see cref="IDgtAppService"/></param>
        /// <returns><see cref="IDgtAppService"/></returns>
        public List<VehicleDriverDTO> GetVehiclesByDriver(string driverIdentifier)
        {
            if (!String.IsNullOrEmpty(driverIdentifier))
            {
                var results =
                    _vehicleDriverRepository.GetFiltered(d =>
                        d.Driver.Identifier.ToLower() == driverIdentifier.ToLower());

                if (results != null && results.Any())
                    return results.OrderBy(d => d.Vehicle.License).ProjectedAsCollection<VehicleDriverDTO>();
                else
                    return null;
            }
            else
                return null;

        }

        /// <summary>
        /// <see cref="IDgtAppService"/>
        /// </summary>
        /// <param name="vehicleLicense"><see cref="IDgtAppService"/></param>
        /// <returns><see cref="IDgtAppService"/></returns>
        public List<VehicleDriverDTO> GetDriversByVehicle(string vehicleLicense)
        {
            if (!String.IsNullOrEmpty(vehicleLicense))
            {
                var results =
                    _vehicleDriverRepository.GetFiltered(d =>
                        d.Vehicle.License.ToLower() == vehicleLicense.ToLower());

                if (results != null && results.Any())
                    return results.OrderBy(d => d.Vehicle.License).ProjectedAsCollection<VehicleDriverDTO>();
                else
                    return null;
            }
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

        private Infraction MaterializeInfractionFromDto(InfractionDTO dto)
        {
            var infraction =
                InfractionFactory.CreateInfraction(dto.VehicleId, dto.InfractionTypeId, dto.DriverId, dto.Date);
            return infraction;
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
