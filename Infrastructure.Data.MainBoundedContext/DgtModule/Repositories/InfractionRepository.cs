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


        #region IInfractionRepository implementation

        /// <summary>
        /// <see cref="IInfractionRepository"/>
        /// </summary>
        /// <returns><see cref="IInfractionRepository"/></returns>
        public IEnumerable<InfractionStats> GetInfractionsStats()
        {
            var currentUnitOfWork = this.UnitOfWork as MainBCUnitOfWork;
            var set = currentUnitOfWork.CreateSet<Infraction>();
            
            var result = set
                .GroupBy(n => n.InfractionType.Name)
                .Select(n => new InfractionStats()
                    {
                        Name= n.Key,
                        Count = n.Count()
                    }
                )
                .OrderBy(n => n.Name);

            return result;
        }


        /// <summary>
        /// <see cref="IInfractionRepository"/>
        /// </summary>
        public int Count()
        {
            var currentUnitOfWork = this.UnitOfWork as MainBCUnitOfWork;
            var set = currentUnitOfWork.CreateSet<Infraction>();
            return set.Count();
        }

        #endregion


    }
}
