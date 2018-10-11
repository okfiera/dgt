using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg
{
    public static  class InfractionFactory
    {
        public static Infraction CreateInfraction(Vehicle vehicle, Driver driver, InfractionType infractionType, DateTime date)
        {
            var infraction = new Infraction()
            {
                VehicleId = vehicle.Id,
                InfractionTypeId = infractionType.Id,
                Date = date
            };

            infraction.SetVehicle(vehicle);
            infraction.SetInfractionType(infractionType);
            infraction.SetDriver(driver);

            return infraction;
        }

        public static Infraction CreateInfraction(Guid vehicleId, Guid infractionTypeId, Guid driverId, DateTime date)
        {
            var infraction = new Infraction()
            {
                VehicleId = vehicleId,
                InfractionTypeId = infractionTypeId,
                DriverId = driverId,
                Date = date
            };

            return infraction;
        }
    }
}
