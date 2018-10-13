using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg
{
    public class InfractionStats
    {
        /// <summary>
        /// Infraction type name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Number el infractions per current infraction type
        /// </summary>
        public int Count { get; set; }
    }
}
