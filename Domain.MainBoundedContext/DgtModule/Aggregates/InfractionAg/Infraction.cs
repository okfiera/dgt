using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;
using Domain.Seedwork;
using Infrastructure.GlobalResources;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg
{
    public class Infraction: Entity, IValidatableObject
    {
        #region Properties

        /// <summary>
        /// Get or set car driver identifier
        /// </summary>
        public Guid DriverId { get; set; }

        /// <summary>
        /// Get car driver
        /// </summary>
        public virtual Driver Driver { get; private set; }

        /// <summary>
        /// Get or set car vehicle identifier
        /// </summary>
        public Guid VehicleId { get; set; }

        /// <summary>
        /// Get car vehicle
        /// </summary>
        public virtual Vehicle Vehicle { get; private set; }

        /// <summary>
        /// Get or set car InfractionType identifier
        /// </summary>
        public Guid InfractionTypeId { get; set; }

        /// <summary>
        /// Get car InfractionType
        /// </summary>
        public virtual InfractionType InfractionType { get; private set; }

        /// <summary>
        /// Get or set infraction date time
        /// </summary>
        public DateTime Date { get; set; }

        #endregion



        #region Public methods

        /// <summary>
        /// Associate vehicle to current infraction
        /// </summary>
        /// <param name="vehicle"></param>
        public void SetVehicle(Vehicle vehicle)
        {
            if (vehicle == null || vehicle.IsTransient())
                throw new ArgumentNullException(String.Format(CommonMessages.exception_CannotAssociateTransientOrNullEntity, Names.Vehicle));

            this.VehicleId = vehicle.Id;
            this.Vehicle = vehicle;
        }

        /// <summary>
        /// Associate driver to current infraction
        /// </summary>
        /// <param name="driver"></param>
        public void SetDriver(Driver driver)
        {
            if (driver == null || driver.IsTransient())
                throw new ArgumentNullException(String.Format(CommonMessages.exception_CannotAssociateTransientOrNullEntity, Names.Driver));

            this.DriverId = driver.Id;
            this.Driver = driver;
        }

        /// <summary>
        /// Associate infractionType to current infraction
        /// </summary>
        /// <param name="infractionType"></param>
        public void SetInfractionType(InfractionType infractionType)
        {
            if (infractionType == null || infractionType.IsTransient())
                throw new ArgumentNullException(String.Format(CommonMessages.exception_CannotAssociateTransientOrNullEntity, Names.InfractionType));

            this.InfractionTypeId = infractionType.Id;
            this.InfractionType = infractionType;
        }

        #endregion



        #region IValidatableObject implementation

        /// <summary>
        /// <see cref="IValidatableObject.Validate"/>
        /// </summary>
        /// <param name="validationContext"><see cref="IValidatableObject.Validate"/></param>
        /// <returns><see cref="IValidatableObject.Validate"/></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            //Check driver
            if (this.DriverId == Guid.Empty)
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.Driver), new string[] { "DriverId" }));

            //Check vehicle
            if (this.VehicleId == Guid.Empty)
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.Vehicle), new string[] { "VehicleId" }));

            //Check infraction type
            if (this.InfractionTypeId == Guid.Empty)
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.InfractionType), new string[] { "InfractionType" }));
            
            //Check Date is passed
            if (this.Date > DateTime.Now)
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.DateTimeMustBePassed, Names.Date), new string[] { "Date" }));


            return validationResults;
        }

        #endregion
    }
}
