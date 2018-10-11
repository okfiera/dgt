using System;
using Domain.Seedwork.Specification;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg
{
    public static class InfractionSpecifications
    {
        /// <summary>
        /// Specification for Infraction with Driver id equals <param name="driverId" />
        /// </summary>
        /// <param name="driverId">The Infraction driver identifier</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Infraction> WithDriverId(Guid? driverId)
        {
            Specification<Infraction> specification = new TrueSpecification<Infraction>();

            //Check arguments
            if (driverId != null && driverId != Guid.Empty)
                specification = new DirectSpecification<Infraction>(v => v.DriverId == driverId);

            return specification;
        }

        /// <summary>
        /// Specification for Infraction with Driver Identifier equals <param name="driverIdentifier" />
        /// </summary>
        /// <param name="driverIdentifier">The Infraction driver identifier</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Infraction> WithDriverIdentifier(string driverIdentifier)
        {
            Specification<Infraction> specification = new TrueSpecification<Infraction>();

            //Check arguments
            if (!String.IsNullOrEmpty(driverIdentifier))
                specification = new DirectSpecification<Infraction>(v => v.Driver.Identifier.ToLower() == driverIdentifier.ToLower());

            return specification;
        }

        /// <summary>
        /// Specification for Infraction with Vehicle Id equals <param name="vehicleId" />
        /// </summary>
        /// <param name="vehicleId">The Infraction vehicle identifier</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Infraction> WithVehicleId(Guid? vehicleId)
        {
            Specification<Infraction> specification = new TrueSpecification<Infraction>();

            //Check arguments
            if (vehicleId != null && vehicleId != Guid.Empty)
                specification = new DirectSpecification<Infraction>(v => v.VehicleId == vehicleId);

            return specification;
        }

        /// <summary>
        /// Specification for Infraction with Vehicle license plate equals <param name="vehicleLicense" />
        /// </summary>
        /// <param name="vehicleLicense">The Infraction vehicle identifier</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Infraction> WithVehicleLicense(string vehicleLicense)
        {
            Specification<Infraction> specification = new TrueSpecification<Infraction>();

            //Check arguments
            if (!String.IsNullOrEmpty(vehicleLicense))
                specification = new DirectSpecification<Infraction>(v => v.Vehicle.License.ToLower() == vehicleLicense.ToLower());

            return specification;
        }

        /// <summary>
        /// Specification for Infraction with Infraction Type Id equals <param name="infractionTypeId" />
        /// </summary>
        /// <param name="infractionTypeId">The Infraction vehicle identifier</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Infraction> WithInfractionType(Guid? infractionTypeId)
        {
            Specification<Infraction> specification = new TrueSpecification<Infraction>();

            //Check arguments
            if (infractionTypeId != null && infractionTypeId != Guid.Empty)
                specification = new DirectSpecification<Infraction>(v => v.InfractionTypeId == infractionTypeId);

            return specification;
        }

        ///  <summary>
        /// Specification for Get Infractions between <param name="from"></param> and <param name="to"></param>
        /// </summary>
        /// <param name="from">Infractions date min criteria></param>
        /// <param name="to">Infractions date max criteria></param>
        /// <returns>Associated specification for this criteria</returns>
        public static Specification<Infraction> WithDateRange(DateTime? from, DateTime? to)
        {
            var fromD = DateTime.MinValue;
            if (from.HasValue)
                fromD = new DateTime(from.Value.Year, from.Value.Month, from.Value.Day);

            var toD = DateTime.Now;
            if (to.HasValue)
                toD = new DateTime(to.Value.Year, to.Value.Month, to.Value.Day).AddDays(1).AddMilliseconds(-1);

            return new DirectSpecification<Infraction>(o => o.Date >= fromD && o.Date <= toD);
        }
        
    }
}
