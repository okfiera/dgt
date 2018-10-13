using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MainBoundedContext.DTO.DgtModule.Vehicles
{
    public class VehicleDTO
    {
        /// <summary>
        /// Get or set Vehicle identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Get or set vehicle license plate
        /// </summary>
        public string License { get; set; }

        /// <summary>
        /// Vehicle brand identifier
        /// </summary>
        public Guid BrandId { get; set; }

        /// <summary>
        /// Vehicle brand name
        /// </summary>
        public string BrandName{ get; set; }

        /// <summary>
        /// Get or set vehicle model
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Vehicle full name
        /// </summary>
        public string VehicleFullName { get; set; }

        /// <summary>
        /// Get or ser habitual driver
        /// </summary>
        public Guid DriverId { get; set; }

        /// <summary>
        /// Get or set Created date
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
