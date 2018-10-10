using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleDriverAgg;
using Infrastructure.GlobalResources;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg
{
    public class Driver: Entity, IValidatableObject
    {
        #region Members

        private const int MAX_POINTS = 15;

        #endregion


        #region Properties

        /// <summary>
        /// Driver identifier (DNF, NIF, NIE)
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Driver first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Driver last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Driver full name (first name with last name)
        /// </summary>
        public string FullName => this.FirstName + " " + this.LastName;

        /// <summary>
        /// Driver remaining points. 
        /// </summary>
        public int Points { get; private set; }

        #endregion


        #region Public methods

        /// <summary>
        /// Remove driver points
        /// </summary>
        /// <param name="pointsToRemove">Points to remove to driver</param>
        /// <returns></returns>
        public int RemovePoints(int pointsToRemove)
        {
            if (this.Points < pointsToRemove)
                this.Points = 0;
            else
                this.Points = this.Points - pointsToRemove;

            return this.Points;
        }

        /// <summary>
        /// Add driver points
        /// </summary>
        /// <param name="pointsToAdd">Points to add to driver</param>
        /// <returns></returns>
        public int AddPoints(int pointsToAdd)
        {
            var p = this.Points + pointsToAdd;

            if (p < MAX_POINTS)
                p = MAX_POINTS;

            this.Points = p;

            return this.Points;
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

            //Check Identifier
            if (String.IsNullOrEmpty(Identifier) || String.IsNullOrWhiteSpace(Identifier))
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.Identifier), new string[] { "Identifier" }));
            else if(Identifier.Length < 5 || Identifier.Length > 25)
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.InvalidFormat, Names.Identifier), new string[] { "Identifier" }));


            //Check First name
            if (String.IsNullOrEmpty(FirstName) || String.IsNullOrWhiteSpace(FirstName))
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.FirstName), new string[] { "FirstName" }));

            //Check Last name
            if (String.IsNullOrEmpty(LastName) || String.IsNullOrWhiteSpace(LastName))
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.FieldCannotBeEmpty, Names.LastName), new string[] { "LastName" }));

            // Check points
            if(this.Points < 0 || this.Points > MAX_POINTS)
                validationResults.Add(new ValidationResult(String.Format(CommonValidations.Range, Names.Points, 0, MAX_POINTS), new string[] { "Points" }));


            return validationResults;
        }

        #endregion
    }
}
