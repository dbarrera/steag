using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Model;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public interface IAuditor
    {
        void Audit(IAuditable auditable, User user);        
    }
}
