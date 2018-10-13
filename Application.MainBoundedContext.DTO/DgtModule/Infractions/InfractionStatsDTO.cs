using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MainBoundedContext.DTO.DgtModule.Infractions
{
    public class InfractionStatsDTO
    {
        /// <summary>
        /// Get or set the InfractionType name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or set infraction count by Infraction Type
        /// </summary>
        public int Count { get; set; }
    }
}
