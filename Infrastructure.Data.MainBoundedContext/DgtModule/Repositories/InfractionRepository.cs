using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg;
using Infrastructure.Data.MainBoundedContext.UnitOfWork;
using Infrastructure.Data.Seedwork;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.Repositories
{
    public class InfractionRepository: Repository<Infraction>, IInfractionRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance of InfractionRepository
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public InfractionRepository(MainBCUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion
    }
}
