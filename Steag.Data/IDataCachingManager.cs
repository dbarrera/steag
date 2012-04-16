using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Steag.Data
{
    public interface IDataCachingManager
    {
        XmlMappingSource MappingSource { get; }

        void ResetMappingSource();
    }
}
