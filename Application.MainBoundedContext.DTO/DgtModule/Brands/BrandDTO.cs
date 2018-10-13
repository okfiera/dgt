using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MainBoundedContext.DTO.DgtModule.Brands
{
    public class BrandDTO
    {

        /// <summary>
        /// Get or set Brand identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Get or set the Brand name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or set Created date
        /// </summary>
        public DateTime CreatedDate { get; set; }

        
    }
}
