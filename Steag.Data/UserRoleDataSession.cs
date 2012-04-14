using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public class UserRoleDataSession: DataSession
    {
        public UserRoleDataSession(User user)
            : base(user)
        { 
        }
    }
}
