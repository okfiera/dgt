using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleDriverAgg;
using Domain.Seedwork;
using Infrastructure.GlobalResources;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg
{
    public class Vehicle: Entity, IValidatableObject
    {

        #region Properties

        /// <summary>
        /// Get or set vehicle license plate
        /// </summary>
        public string License { get; set; }

        /// <summary>
        /// Card brand identifier
        /// </summary>
        public Guid BrandId { get; set; }

        public virtual Brand Brand{ get; private set; }

        /// <summary>
        /// Get or set vehicle model
        /// </summary>
        public string Model { get; set; }

  #endregion


        #region Public methods

        /// <summary>
        /// Associate brand to current car
        /// </summary>
        /// <param name="brand"></param>
        public void SetBrand(Brand brand)
        {
            if(brand == null || brand.IsTransient())
                throw new ArgumentNullException(String.Format(CommonMessages.exception_CannotAssociateTransientOrNullEntity, Names.Brand));

            this.BrandId = brand.Id;
            this.Brand = brand;
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

            //Check license
            if (String.IsNullOrEmpty(License) || String.IsNullOrWhiteSpace(License))
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.License), new string[] { "License" }));
            
            //Check model
            if (String.IsNullOrEmpty(Model) || String.IsNullOrWhiteSpace(Model))
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.Model), new string[] { "Model" }));

            //Check brand
            if (this.BrandId == Guid.Empty)
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.Brand), new string[] { "BrandId" }));
            
            return validationResults;
        }

        #endregion
    }
}
