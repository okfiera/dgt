using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;
using Infrastructure.Data.MainBoundedContext.UnitOfWork;
using Infrastructure.Data.Seedwork;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.Repositories
{
    public class VehicleRepository: Repository<Vehicle>, IVehicleRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance of VehicleRepository
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public VehicleRepository(MainBCUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion
    }
}
