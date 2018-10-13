using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MainBoundedContext.DTO.DgtModule.Infractions
{
    public class InfractionDTO
    {
        /// <summary>
        /// Get or set infraction identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Get or set infraction driver identifier
        /// </summary>
        public Guid DriverId { get; set; }

        /// <summary>
        /// Driver infraction driver full name
        /// </summary>
        public string DriverFullName { get; set; }

        /// <summary>
        /// Get or set infraction driver identifier
        /// </summary>
        public string DriverIdentifier { get; set; }

        /// <summary>
        /// Get or set infraction vehicle identifier
        /// </summary>
        public Guid VehicleId { get; set; }

        /// <summary>
        /// Get or set infraction vehicle license
        /// </summary>
        public string VehicleLicense { get; set; }

        /// <summary>
        /// Get or set infraction vehicle brand and model
        /// </summary>
        public string VehicleFullName { get; set; }

        /// <summary>
        /// Get or set Infraction type identifier
        /// </summary>
        public Guid InfractionTypeId { get; set; }
        
        /// <summary>
        /// Get or set infraction type name
        /// </summary>
        public string InfractionTypeName { get; set; }

        /// <summary>
        /// Get or set infraction points
        /// </summary>
        public int InfractionPoints { get; set; }

        /// <summary>
        /// Get or set infraction date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Get or set Created date
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
