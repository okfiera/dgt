using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg
{
    public static class DriverFactory
    {
        public static Driver CreateDriver(string identifier, string firstName, string lastName, int? points)
        {
            var driver = new Driver()
            {
                Identifier = identifier,
                FirstName = firstName,
                LastName = lastName
            };

            if (points != null)
                driver.Points = points.Value;

            return driver;
        }
    }
    
}
