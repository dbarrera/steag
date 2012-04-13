using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Caching
{
    public interface ICacheFactory
    {
        ICache GetCache(string cacheName);

    }
}
