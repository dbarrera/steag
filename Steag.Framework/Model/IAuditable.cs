using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Model
{
    public interface IAuditable
    {
        Int64 UserCreated { get; set; }
        DateTime DateCreated { get;  set; }

        Int64 UserModified { get; set; }
        DateTime DateModified { get; set; }
    }
}
