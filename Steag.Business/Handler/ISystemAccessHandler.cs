using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Business.Handler
{
    public interface ISystemAccessHandler
    {
        bool HasAccess(Int64 roleID, string identity);
    }
}
