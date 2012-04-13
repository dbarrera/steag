using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Caching
{
    public class CacheFactory: ICacheFactory
    {
        private Dictionary<string, ICache> _cacheContainer;
        private static ICacheFactory _cacheFactory;

        private Dictionary<string, ICache> Caches
        {
            get
            {
                _cacheContainer = _cacheContainer ?? new Dictionary<string, ICache>();
                return _cacheContainer;
            }
        }

        public ICache GetCache(string cacheName)
        {
            if (Equals(cacheName, null))
                throw new ArgumentNullException("cacheName");

            if(!Caches.ContainsKey(cacheName))
            {
                var cache = new Cache();
                Caches.Add(cacheName, cache);
                return cache;
            }
            return Caches[cacheName];
        }

        private CacheFactory()
        {
            
        }

        public static ICacheFactory Current
        {
            get
            {
                return _cacheFactory ?? new CacheFactory();
            }
        }

        public static void SetCurrent(ICacheFactory factory)
        {
            _cacheFactory = factory;
        }

    }
}
