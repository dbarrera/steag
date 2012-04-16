using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public class UserRoleAcccessDataSession: DataSession
    {
 
        public UserRoleAcccessDataSession(IDataSource dataSource)
            : base(dataSource)
        { 
        }

        public UserRoleAcccessDataSession(User user, IDataSource dataSource)
            : base(user, dataSource)
        {
        }
    }
}
