using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleDriverAgg;
using Infrastructure.Data.MainBoundedContext.UnitOfWork;
using Infrastructure.Data.Seedwork;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.Repositories
{
    public class VehicleDriverRepository: Repository<VehicleDriver>, IVehicleDriverRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance of VehicleDriverRepository
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public VehicleDriverRepository(MainBCUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion
    }
}
