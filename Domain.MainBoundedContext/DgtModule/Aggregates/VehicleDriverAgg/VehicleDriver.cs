using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;
using Domain.Seedwork;
using Infrastructure.GlobalResources;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.VehicleDriverAgg
{
    public class VehicleDriver : BaseEntity, IValidatableObject
    {
        #region Members
        #endregion



        #region Properties

        /// <summary>
        /// Associated vehicle identifier
        /// </summary>
        public Guid VehicleId { get; set; }

        /// <summary>
        /// Associated vehicle
        /// </summary>
        public virtual Vehicle Vehicle { get; private set; }

        /// <summary>
        /// Associated driver identifier
        /// </summary>
        public Guid DriverId { get; set; }

        /// <summary>
        /// Associated driver
        /// </summary>
        public virtual Driver Driver { get; private set; }

        #endregion



        #region Public methods

        /// <summary>
        /// Associate brand to current car
        /// </summary>
        /// <param name="brand"></param>
        public void SetVehicle(Vehicle brand)
        {
            if (brand == null || brand.IsTransient())
                throw new ArgumentNullException(String.Format(CommonMessages.exception_CannotAssociateTransientOrNullEntity, Names.Vehicle));

            this.VehicleId = brand.Id;
            this.Vehicle = brand;
        }

        /// <summary>
        /// Associate brand to current car
        /// </summary>
        /// <param name="brand"></param>
        public void SetDriver(Driver brand)
        {
            if (brand == null || brand.IsTransient())
                throw new ArgumentNullException(String.Format(CommonMessages.exception_CannotAssociateTransientOrNullEntity, Names.Driver));

            this.DriverId = brand.Id;
            this.Driver = brand;
        }

        #endregion



        #region IValidatableObject implementation

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            //Check vehicle
            if (this.VehicleId == Guid.Empty)
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.Vehicle), new string[] { "VehicleId" }));

            //Check driver
            if (this.DriverId == Guid.Empty)
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.Driver), new string[] { "DriverId" }));


            return validationResults;
        }

        #endregion
    }
}
