using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Steag.Data;
using Steag.Framework.Model;
using Steag.Framework.Authentication;

namespace Steag.Web.Presentation.Security.Audit
{
    public class Auditor: IAuditor
    {
        public void Audit(IAuditable auditable, User user)
        {
            if (auditable.ID > 0)
            {
                auditable.UserModified = user.UserID;
                auditable.DateModified = DateTime.Now;
            }
            else
            {
                auditable.UserCreated = user.UserID;
                auditable.DateCreated = DateTime.Now;
            }
        }
    }
}