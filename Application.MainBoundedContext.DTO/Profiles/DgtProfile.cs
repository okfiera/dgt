using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using AutoMapper;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;

namespace Application.MainBoundedContext.DTO.Profiles
{
    public class DgtProfile: Profile
    {
        /// <summary>
        /// Create a new instance of DgtProfile
        /// </summary>
        public DgtProfile()
        {
            CreateMap<Brand, BrandDTO>();
            CreateMap<InfractionType, InfractionTypeDTO>();
        }
    }
}
