using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Steag.Framework.Caching;

namespace Test.Steag.Framework.Caching
{
    [TestClass]
    public class CacheTest
    {
        [TestMethod]
        public void TestByKey()
        {
            var cache = new Cache();
            cache.Add("TestKey", 1);

            Assert.IsTrue(Equals(cache["TestKey"], 1));

        }
    }
}
