using System;
using Domain.Seedwork.Specification;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg
{
    public static class InfractionSpecifications
    {
        /// <summary>
        /// Specification for Infraction with Driver Identifier equals <param name="driverId" />
        /// </summary>
        /// <param name="driverId">The Infraction driver identifier</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Infraction> WithDriver(Guid? driverId)
        {
            Specification<Infraction> specification = new TrueSpecification<Infraction>();

            //Check arguments
            if (driverId != null && driverId != Guid.Empty)
                specification = new DirectSpecification<Infraction>(v => v.DriverId == driverId);

            return specification;
        }

        /// <summary>
        /// Specification for Infraction with Vehicle Identifier equals <param name="driverId" />
        /// </summary>
        /// <param name="driverId">The Infraction vehicle identifier</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Infraction> WithVehicle(Guid? driverId)
        {
            Specification<Infraction> specification = new TrueSpecification<Infraction>();

            //Check arguments
            if (driverId != null && driverId != Guid.Empty)
                specification = new DirectSpecification<Infraction>(v => v.VehicleId == driverId);

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
