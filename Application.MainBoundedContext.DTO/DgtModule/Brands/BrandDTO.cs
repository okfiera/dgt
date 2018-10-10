using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MainBoundedContext.DTO.DgtModule.Brands
{
    [Serializable]
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
    }
}
