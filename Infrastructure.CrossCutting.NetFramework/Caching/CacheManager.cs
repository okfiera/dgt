using Infrastructure.Crosscutting.Caching;
using System;
using System.Configuration;
using System.Runtime.Caching;


namespace Infrastructure.Crosscutting.NetFramework.Caching
{
    /// <summary>
    /// Cache manager implementation
    /// </summary>
    public sealed class CacheManager
        : ICacheManager
    {
        #region Members

        private ObjectCache _defaultCache;
        private readonly bool _cacheEnabled;

        #endregion



        #region Constructor

        /// <summary>
        /// Create a new instance of CacheManager
        /// </summary>
        public CacheManager()
        {
            var strCacheEnabled = ConfigurationManager.AppSettings["CacheEnabled"];
            Boolean.TryParse(strCacheEnabled, out _cacheEnabled);

        }

        #endregion



        #region ICacheManager implementation

        /// <summary>
        /// <see cref="ICacheManager"/>
        /// </summary>
        /// <typeparam name="TResult"><see cref="ICacheManager"/></typeparam>
        /// <param name="cacheItemConfig"><see cref="ICacheManager"/></param>
        /// <param name="result"><see cref="ICacheManager"/></param>
        /// <returns><see cref="ICacheManager"/></returns>
        public bool TryGet<TResult>(CacheItemConfig cacheItemConfig, out TResult result)
        {
            if (cacheItemConfig != null)
            {
                //get default cache
                _defaultCache = MemoryCache.Default;
                string cacheKey = cacheItemConfig.CacheKey.GetCacheKey();


                object cacheItem = _defaultCache[cacheKey];
                
                //Check if Cache is Enabled
                if (!_cacheEnabled)
                    cacheItem = null;

                if(cacheItem != null && _cacheEnabled)
                {
                    try
                    {
                        result = (TResult)cacheItem;
                        return true;
                    }
                    catch (Exception)
                    {
                        result = default(TResult);
                        return false;
                    }
                   
                }
                else
                {
                    result = default(TResult);
                    return false;
                }
            }
            else
                throw new ArgumentNullException("cacheItemConfig");
        }

        /// <summary>
        /// <see cref="ICacheManager"/>
        /// </summary>
        /// <param name="cacheItemConfig"><see cref="ICacheManager"/></param>
        /// <param name="value"><see cref="ICacheManager"/></param>
        public void Add(CacheItemConfig cacheItemConfig, object value)
        {
            if (value != null && cacheItemConfig != null)
            {
                //get default cache
                _defaultCache = MemoryCache.Default;

                var cachekey = cacheItemConfig.CacheKey.GetCacheKey();
                var expirationTime = cacheItemConfig.ExpirationTime;
                var cacheItemPolicy = new CacheItemPolicy
                                          {
                                              AbsoluteExpiration = DateTimeOffset.Now.AddTicks(expirationTime.Ticks)
                                          };

                _defaultCache.Add(cachekey, value, cacheItemPolicy);
            }
        }

        /// <summary>
        /// <see cref="ICacheManager"/>
        /// </summary>
        /// <param name="cacheKey"><see cref="ICacheManager"/></param>
        /// <returns><see cref="ICacheManager"/></returns>
        public bool Remove(CacheKey cacheKey)
        {
            //get default cache
            _defaultCache = MemoryCache.Default;

            if (!_defaultCache.Contains(cacheKey.KeyName))
                return false;
            else
            {
                _defaultCache.Remove(cacheKey.KeyName);
                return true;
            }
        }

        /// <summary>
        /// <see cref="ICacheManager"/>
        /// </summary>
        /// <returns><see cref="ICacheManager"/></returns>
        public void ClearAll()
        {
            MemoryCache.Default.Dispose();
            _defaultCache = MemoryCache.Default;
        }

        #endregion
        
    }
}
