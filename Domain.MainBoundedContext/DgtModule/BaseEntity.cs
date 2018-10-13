using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Seedwork;

namespace Domain.MainBoundedContext.DgtModule
{
    public abstract class BaseEntity: Entity
    {
        /// <summary>
        /// Get or set created date
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
