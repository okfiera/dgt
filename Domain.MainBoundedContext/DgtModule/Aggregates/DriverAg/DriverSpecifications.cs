using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Seedwork.Specification;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg
{
    public static class DriverSpecifications
    {
        /// <summary>
        /// Specification for Driver with Identifier equals <param name="identifier" />
        /// </summary>
        /// <param name="identifier">The Driver identifier (Nif, Nie, ...)</param>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Driver> WithIdentifier(string identifier)
        {
            //Check arguments
            if (string.IsNullOrEmpty(identifier))
                throw new ArgumentNullException("Identifier");

            return new DirectSpecification<Driver>(p => p.Identifier.ToUpper().Equals(identifier.ToUpper()));
        }

        /// <summary>
        /// Specification for Driver with points (> 0) />
        /// </summary>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Driver> Enabled()
        {
            //Check arguments
            return new DirectSpecification<Driver>(p => p.Points > 0);
        }

        /// <summary>
        /// Specification for Driver without points (== 0) />
        /// </summary>
        /// <returns>Associated specification for this criterion</returns>
        public static Specification<Driver> Disabled()
        {
            //Check arguments
            return new DirectSpecification<Driver>(p => p.Points == 0);
        }

        /// <summary>
        /// Specification for Driver with name, domain or comments like <param name="text"></param>
        /// </summary>
        /// <param name="text">Tex to search</param>
        /// <returns>Associated specification for this criteria</returns>
        public static Specification<Driver> FullText(string text)
        {
            Specification<Driver> specification = new TrueSpecification<Driver>();

            if (!String.IsNullOrEmpty(text))
            {
                var firstNameSpec = new DirectSpecification<Driver>(s => s.FirstName.ToLower().Contains(text.ToLower()));
                var lastNameSpec = new DirectSpecification<Driver>(s => s.LastName.ToLower().Contains(text.ToLower()));
                var identifierSpec = new DirectSpecification<Driver>(s => s.Identifier.ToLower().Contains(text.ToLower()));

                specification &= (firstNameSpec || lastNameSpec || identifierSpec);
            }

            return specification;
        }
    }
}
