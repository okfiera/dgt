using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;
using Infrastructure.Data.MainBoundedContext.UnitOfWork;
using Infrastructure.Data.Seedwork;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.Repositories
{
    public class InfractionTypeRepository: Repository<InfractionType>, IInfractionTypeRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance of InfractionTypeRepository
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public InfractionTypeRepository(MainBCUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion
    }
}
