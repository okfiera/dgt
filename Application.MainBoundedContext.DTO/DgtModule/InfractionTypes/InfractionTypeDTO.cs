using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MainBoundedContext.DTO.DgtModule.InfractionTypes
{
    public class InfractionTypeDTO
    {
        /// <summary>
        /// Get or set Brand identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Infraction type name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Infraction type associated points
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Infraction type description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Get or set Created date
        /// </summary>
        public DateTime? CreatedDate { get; set; }
    }
}
