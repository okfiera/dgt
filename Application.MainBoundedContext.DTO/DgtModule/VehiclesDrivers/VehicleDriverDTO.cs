using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MainBoundedContext.DTO.DgtModule.VehiclesDrivers
{
    public class VehicleDriverDTO
    {
        /// <summary>
        /// Get or set identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Associated vehicle identifier
        /// </summary>
        public Guid VehicleId { get; set; }

        /// <summary>
        /// Associated vehicle
        /// </summary>
        public string VehicleName{ get; set; }

        /// <summary>
        /// Associated vehicle license
        /// </summary>
        public string VehicleLicense { get; set; }

        /// <summary>
        /// Associated driver identifier
        /// </summary>
        public Guid DriverId { get; set; }

        /// <summary>
        /// Associated driver full name
        /// </summary>
        public string DriverFullName { get; set; }

        /// <summary>
        /// Associated driver identifier
        /// </summary>
        public string DriverIdentifier { get; set; }

        /// <summary>
        /// Associated Driver Points
        /// </summary>
        public int DriverPoints { get; set; }
    }
}
