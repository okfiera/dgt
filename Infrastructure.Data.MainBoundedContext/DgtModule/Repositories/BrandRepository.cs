using Domain.Seedwork;
using Domain.Seedwork.Specification;
using Infrastructure.Data.MainBoundedContext.UnitOfWork;
using Infrastructure.Data.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.Repositories
{
    public class BrandRepository: Repository<Brand>, IBrandRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance of BrandRepository
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public BrandRepository(MainBCUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion
    }
}
