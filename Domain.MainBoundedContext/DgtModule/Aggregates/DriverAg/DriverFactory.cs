using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg
{
    public static class DriverFactory
    {
        private const int MAX_POINTS = 12;

        public static Driver CreateDriver(string identifier, string firstName, string lastName, int points = MAX_POINTS)
        {
            var driver = new Driver()
            {
                Identifier = identifier,
                FirstName = firstName,
                LastName = lastName
            };

            driver.AddPoints(points);

            return driver;
        }
    }
    
}
