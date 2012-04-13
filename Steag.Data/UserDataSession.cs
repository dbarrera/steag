using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Model;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public class UserDataSession: DataSession
    {
        public UserDataSession(User user)
            :base(user)
        { 
        }

        public UserAccount GetUserAccount(Int64 id)
        {
            return default(UserAccount);
        }

        public UserAccount GetUserAccountByUserName(string username)
        {
            return default(UserAccount);
        }
    }
}
