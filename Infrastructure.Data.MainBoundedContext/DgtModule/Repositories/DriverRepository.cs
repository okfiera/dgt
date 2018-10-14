using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;
using Infrastructure.Data.MainBoundedContext.UnitOfWork;
using Infrastructure.Data.Seedwork;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.Repositories
{
    public class DriverRepository: Repository<Driver>, IDriverRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance of DriverRepository
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public DriverRepository(MainBCUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion



        #region IDriverRespository

        public int Count()
        {
            var currentUnitOfWork = this.UnitOfWork as MainBCUnitOfWork;
            var set = currentUnitOfWork.CreateSet<Driver>();

            return set.Count();
        }

        #endregion
    }
}
