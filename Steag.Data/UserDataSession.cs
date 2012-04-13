using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Model;

namespace Steag.Data
{
    public class UserDataSession: DataSession
    {
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
