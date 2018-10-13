using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MainBoundedContext.DTO.DgtModule.Drivers
{
    public class DriverDTO
    {
        /// <summary>
        /// Get or set Driver identifier
        /// </summary>
        public Guid Id { get; set; }

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
        public string FullName { get; set; }

        /// <summary>
        /// Driver remaining points. 
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Get or set Created date
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
