using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;
using Application.MainBoundedContext.DTO.DgtModule.Infractions;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using Application.MainBoundedContext.DTO.DgtModule.Vehicles;
using Application.MainBoundedContext.DTO.DgtModule.VehiclesDrivers;
using AutoMapper;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleDriverAgg;

namespace Application.MainBoundedContext.DTO.Profiles
{
    public class DgtProfile : Profile
    {
        /// <summary>
        /// Create a new instance of DgtProfile
        /// </summary>
        public DgtProfile()
        {
            // Brand => BrandDTO
            CreateMap<Brand, BrandDTO>();

            // InfractionType => InfractionTypeDTO
            CreateMap<InfractionType, InfractionTypeDTO>();

            // Driver => DriverDTO
            CreateMap<Driver, DriverDTO>();

            // Vehicle => VehicleDTO
            var vehicleConfig = CreateMap<Vehicle, VehicleDTO>();
            vehicleConfig.ForMember(dto => dto.BrandName, (map) => map.MapFrom(p => p.Brand.Name));

            // Infraction => InfractionDTO
            var infractionConfig = CreateMap<Infraction, InfractionDTO>();
            infractionConfig.ForMember(dto => dto.DriverFullName, (map) => map.MapFrom(i => i.Driver.FullName));
            infractionConfig.ForMember(dto => dto.DriverIdentifier, (map) => map.MapFrom(i => i.Driver.Identifier));
            infractionConfig.ForMember(dto => dto.VehicleLicense, (map) => map.MapFrom(i => i.Vehicle.License));
            infractionConfig.ForMember(dto => dto.VehicleFullName, (map) => map.MapFrom(i => i.Vehicle.Brand.Name + " " + i.Vehicle.Model));
            infractionConfig.ForMember(dto => dto.InfractionTypeName, (map) => map.MapFrom(i => i.InfractionType.Name));
            infractionConfig.ForMember(dto => dto.InfractionPoints, (map) => map.MapFrom(i => i.InfractionType.Points));

            // VehicleDriver => VehicleDriverDTO
            var vehicleDriverConfig = CreateMap<VehicleDriver, VehicleDriverDTO>();
            vehicleDriverConfig.ForMember(dto => dto.VehicleLicense, (map) => map.MapFrom(i => i.Vehicle.License));
            vehicleDriverConfig.ForMember(dto => dto.VehicleName, (map) => map.MapFrom(i => i.Vehicle.Brand.Name + " " + i.Vehicle.Model));
            vehicleDriverConfig.ForMember(dto => dto.DriverFullName, (map) => map.MapFrom(i => i.Driver.FullName));
            vehicleDriverConfig.ForMember(dto => dto.DriverIdentifier, (map) => map.MapFrom(i => i.Driver.Identifier));
            vehicleDriverConfig.ForMember(dto => dto.DriverPoints, (map) => map.MapFrom(i => i.Driver.Points));

        }
    }
}
