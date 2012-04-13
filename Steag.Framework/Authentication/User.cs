using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Authentication
{
    public class User
    {
        public Int64 RoleID { get; private set; }

        public Int64 UserID { get; private set; }

        public string UserName { get; private set; }

        public User(Int64 roleID, Int64 userID, string userName)
        {
            RoleID = roleID;
            UserID = userID;
            UserName = userName;
        }
    }
}
