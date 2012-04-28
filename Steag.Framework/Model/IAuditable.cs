using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Model
{
    public interface IAuditable
    {
        long ID { get; set; }

        long? UserCreated { get; set; }
        DateTime? DateCreated { get; set; }

        long? UserModified { get; set; }
        DateTime? DateModified { get; set; }
    }
}
