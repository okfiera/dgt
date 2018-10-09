using System;
using Domain.Seedwork.Specification;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg
{
    public static class VehicleSpecifications
    {
        /// <summary>
        /// Specification for Vehicle with License equals <param name="license" />
        /// </summary>
        /// <param name="license">Car license plate</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Vehicle> WithLicense(string license)
        {
            //Check arguments
            if (string.IsNullOrEmpty(license))
                throw new ArgumentNullException("license");

            return new DirectSpecification<Vehicle>(p => p.License.ToUpper().Equals(license.ToUpper()));
        }

        /// <summary>
        /// Specification for Vehicle with Brand equals <param name="brandId" />
        /// </summary>
        /// <param name="brandId">Car brand plate</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Vehicle> WithBrand(Guid? brandId)
        {
            Specification<Vehicle> specification = new TrueSpecification<Vehicle>();
            
            //Check arguments
            if (brandId != null && brandId != Guid.Empty)
                specification = new DirectSpecification<Vehicle>(v => v.BrandId == brandId);

            return specification;
        }

        /// <summary>
        /// Specification for Vehicle with Driver equals <param name="driverId" />
        /// </summary>
        /// <param name="driverId">Car driver plate</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Vehicle> WithDriver(Guid? driverId)
        {
            Specification<Vehicle> specification = new TrueSpecification<Vehicle>();

            //Check arguments
            if (driverId != null && driverId != Guid.Empty)
                specification = new DirectSpecification<Vehicle>(v => v.DriverId == driverId);

            return specification;
        }

        /// <summary>
        /// Specification for Vehicle with model equals to <param name="model"></param>
        /// </summary>
        /// <param name="model">Tex to search</param>
        /// <returns>Associated specification for this criteria</returns>
        public static Specification<Vehicle> WithModel(string model)
        {
            Specification<Vehicle> specification = new TrueSpecification<Vehicle>();

            //Check arguments
            if (!String.IsNullOrEmpty(model))
                specification = new DirectSpecification<Vehicle>(s => s.Model.ToLower().Contains(model.ToLower()));

            return specification;
        }
    }
}
