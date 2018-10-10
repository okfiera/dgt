using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Seedwork.Specification;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.VehicleDriverAgg
{
    public static class VehicleDriverSpecifications
    {

        /// <summary>
        /// Specification for VehicleDriver with Driver equals <param name="driverId" />
        /// </summary>
        /// <param name="driverId">Car driver plate</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<VehicleDriver> WithDriver(Guid? driverId)
        {
            Specification<VehicleDriver> specification = new TrueSpecification<VehicleDriver>();

            //Check arguments
            if (driverId != null && driverId != Guid.Empty)
                specification = new DirectSpecification<VehicleDriver>(v => v.DriverId == driverId);

            return specification;
        }

        /// <summary>
        /// Specification for VehicleDriver with Vehicle equals <param name="vehicleId" />
        /// </summary>
        /// <param name="vehicleId">Car vehicle plate</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<VehicleDriver> WithVehicle(Guid? vehicleId)
        {
            Specification<VehicleDriver> specification = new TrueSpecification<VehicleDriver>();

            //Check arguments
            if (vehicleId != null && vehicleId != Guid.Empty)
                specification = new DirectSpecification<VehicleDriver>(v => v.VehicleId == vehicleId);

            return specification;
        }
    }
}
