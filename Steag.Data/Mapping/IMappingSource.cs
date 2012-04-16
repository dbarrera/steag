using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Data.Mapping
{
    public interface IMappingSource: IDisposable
    {
        string MappingSourceFile { get; }
    }
}
