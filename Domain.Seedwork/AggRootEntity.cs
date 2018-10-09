using System;

namespace Domain.Seedwork
{
    /// <summary>
    /// Aggregate root class inherited from Entity, that register Entity comments,  created date and modified date
    /// </summary>
    public abstract class AggRootEntity
        : Entity
    {
        #region Properties

        /// <summary>
        /// Get or set Entity comments
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Get or set Entity created date
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Get or set Entity modified D
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Create a new instance of AggRootEntity
        /// </summary>
        protected AggRootEntity()
        {
            this.CreatedDate = DateTime.Now;
            this.ModifiedDate = DateTime.Now;
        }

        #endregion Constructor
    }
}
