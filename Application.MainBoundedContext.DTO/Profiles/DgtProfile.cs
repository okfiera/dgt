using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using Application.MainBoundedContext.DTO.DgtModule.Vehicles;
using AutoMapper;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;

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
        }
    }
}
