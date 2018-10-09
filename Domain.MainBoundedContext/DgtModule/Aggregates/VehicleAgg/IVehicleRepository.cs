using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Seedwork;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg
{
    public interface IVehicleRepository: IRepository<Vehicle>
    {
    }
}
