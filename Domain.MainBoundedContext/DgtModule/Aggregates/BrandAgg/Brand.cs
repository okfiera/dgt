using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Seedwork;
using Infrastructure.GlobalResources;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg
{
    public class Brand: Entity, IValidatableObject
    {
        #region Properties

        /// <summary>
        /// Get or set Brand name
        /// </summary>
        public string Name { get; set; }

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
           
            //Check First name
            if (String.IsNullOrEmpty(Name) || String.IsNullOrWhiteSpace(Name))
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.Name), new string[] { "Name" }));

          
            return validationResults;
        }

        #endregion
    }
}
