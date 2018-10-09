
namespace Infrastructure.Crosscutting.Caching
{
    /// <summary>
    /// Base contract for cache manager. This contract
    /// expose basic methods for work with cache in solution
    /// </summary>
    public interface ICacheManager
    {
        /// <summary>
        /// Try get if object exist in cache and set result in <paramref name="result"/>
        /// </summary>
        /// <typeparam name="TResult">type of returned result</typeparam>
        /// <param name="cacheItemConfig">Cahe item specification</param>
        /// <param name="result">result if exist in cache</param>
        /// <returns>True if object exist in cache, else false</returns>
        bool TryGet<TResult>(CacheItemConfig cacheItemConfig, out TResult result);

        /// <summary>
        /// Add new object in underliying cache
        /// </summary>
        /// <param name="cacheItemConfig">The cache item spec</param>
        /// <param name="value">The item to add</param>
        void Add(CacheItemConfig cacheItemConfig, object value);

        /// <summary>
        /// Remove object in cache
        /// </summary>
        /// <param name="cacheKey">Key identifier of item to delete</param>
        /// <returns>
        /// True if element is removed in cache, if not false
        /// </returns>
        bool Remove(CacheKey cacheKey);

        /// <summary>
        /// Remove object in cache
        /// </summary>
        /// <returns>
        /// Remove all items from cache
        /// </returns>
        void ClearAll();
    }
}
