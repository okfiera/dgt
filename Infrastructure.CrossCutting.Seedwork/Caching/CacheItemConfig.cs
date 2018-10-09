using System;

namespace Infrastructure.Crosscutting.Caching
{
    /// <summary>
    /// A cache item configuration
    /// </summary>
    public class CacheItemConfig
    {
        #region Properties

        readonly CacheKey _cacheKey;
        /// <summary>
        /// Get the associated cached key
        /// </summary>
        public CacheKey CacheKey
        {
            get
            {
                return _cacheKey;
            }
        }

        readonly TimeSpan _expirationTime;
        /// <summary>
        /// Get the associted expiration time
        /// </summary>
        public TimeSpan ExpirationTime
        {
            get
            {
                return _expirationTime;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Create a new instance of cache item
        /// </summary>
        /// <param name="cacheKey">The cached key</param>
        public CacheItemConfig(CacheKey cacheKey)
            : this(cacheKey, new TimeSpan(0, 0, 10))
        {
        }

        /// <summary>
        /// Create a new instance of cache item
        /// </summary>
        /// <param name="cacheKey">The cached key</param>
        /// <param name="expirationTime">Associated expiration time</param>
        public CacheItemConfig(CacheKey cacheKey, TimeSpan expirationTime)
        {
            if (cacheKey == (CacheKey)null)
                throw new ArgumentNullException("cacheKey");

            _cacheKey = cacheKey;
            _expirationTime = expirationTime;

        }

        #endregion

    }
}
