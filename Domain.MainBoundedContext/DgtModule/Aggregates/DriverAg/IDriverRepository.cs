using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Seedwork;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg
{
    public interface IDriverRepository: IRepository<Driver>
    {
        /// <summary>
        /// Get total drivers
        /// </summary>
        int Count();
    }
}
