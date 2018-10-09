using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Seedwork;
using Infrastructure.GlobalResources;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg
{
    public class InfractionType: Entity, IValidatableObject
    {
        #region Members

        private const int MAX_POINTS = 15;

        #endregion



        #region Properties

        /// <summary>
        /// Infraction type name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Infraction type associated points
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Infraction type description
        /// </summary>
        public string Description { get; set; }

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

           
            //Check Last name
            if (String.IsNullOrEmpty(Name) || String.IsNullOrWhiteSpace(Name))
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.Name), new string[] { "Name" }));

            // Check points
            if (this.Points < 0 || this.Points > MAX_POINTS)
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.Range, Names.Points, 0, MAX_POINTS), new string[] { "Points" }));


            return validationResults;
        }

        #endregion
    }
}
