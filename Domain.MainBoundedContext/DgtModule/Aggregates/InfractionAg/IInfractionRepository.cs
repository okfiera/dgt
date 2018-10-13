using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Seedwork;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg
{
    public interface IInfractionRepository:IRepository<Infraction>
    {
        /// <summary>
        /// Get Infractions grouped by Type
        /// </summary>
        /// <returns></returns>
        IEnumerable<InfractionStats> GetInfractionsStats();
    }
}
