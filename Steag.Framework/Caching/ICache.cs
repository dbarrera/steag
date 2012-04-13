using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Caching
{
    public interface ICache
    {
        object this[string key] { get; set; }

        void Add(string key, object value);

        bool ContainsKey(string key);

        bool ContainsValue(object value);

        bool Remove(string key);
    }
}
