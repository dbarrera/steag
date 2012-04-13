using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Steag.Framework.Caching;

namespace Test.Steag.Framework.Caching
{
    [TestClass]
    public class CacheFactoryTest
    {
        [TestMethod]
        public void TestGetCache()
        {
            var cacheFactory = CacheFactory.Current;
            var cache = cacheFactory.GetCache("newCache");
            Assert.IsTrue(!Equals(cache, null));
        }

        [TestMethod]
        public void TestGetCacheExisting()
        {
            var cacheFactory = CacheFactory.Current;
            var cache = cacheFactory.GetCache("newCache");
            cache.Add("TestKey", "TestValue");

            var newCache = cacheFactory.GetCache("newCache");
            Assert.IsTrue(Equals(newCache["TestKey"], "TestValue"));
        }

        [TestMethod]
        public void TestGetCacheByNull()
        {
            var cacheFactory = CacheFactory.Current;
            try
            {
                var cache = cacheFactory.GetCache(null);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentNullException);
            }
            
        }
    }
}
