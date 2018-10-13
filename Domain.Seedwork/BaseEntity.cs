using System;

namespace Domain.Seedwork
{
    public abstract class BaseEntity: Entity
    {
        #region Properties

        /// <summary>
        /// Get or set created date
        /// </summary>
        public DateTime CreatedDate { get; set; }

        #endregion



        #region Constructor

        /// <summary>
        /// Create a new instance of AggRootEntity
        /// </summary>
        protected BaseEntity()
        {
            this.CreatedDate = DateTime.Now;
        }

        #endregion

    }
}
