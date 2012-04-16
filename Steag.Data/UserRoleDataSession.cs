using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public class UserRoleDataSession: DataSession
    {

        public UserRoleDataSession(IDataSource dataSource)
            : base(dataSource)
        { 
        }

        public UserRoleDataSession(User user, IDataSource dataSource)
            : base(user, dataSource)
        { 
        
        }
    }
}
