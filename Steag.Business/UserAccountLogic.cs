using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;
using Steag.Framework.Security;
using Steag.Framework.Model;
using Steag.Data;

namespace Steag.Business
{
    public class UserAccountLogic: LogicBase
    {
        public event EventHandler UserNotFound;

        public UserAccount GetUserByID(long id)
        {
            using (var userAccountSession = new UserAccountDataSession())
            {
                return userAccountSession.GetUserByID(id);
            }
        }

        public UserAccount GetUserByUserName(string userName)
        {
            using (var userAccountSession = new UserAccountDataSession())
            {
                return userAccountSession.GetUserByUserName(userName);
            }
        }

        public IEnumerable<UserAccount> GetAllUsers()
        {
            using (var userAccountSession = new UserAccountDataSession())
            {
                return userAccountSession.GetAllUsers();
            }
        }

        public IEnumerable<UserAccount> GetAllUsers(bool isActive)
        {
            using (var userAccountSession = new UserAccountDataSession())
            {
                return userAccountSession.GetAllUsers(isActive);
            }
        }

        public bool AllowLogin(string username, string password, ref User user)
        {
            var userAccount = GetUserByUserName(username);

            if (Equals(userAccount, null))
            {
                if (!Equals(UserNotFound, null))
                    UserNotFound.Invoke(this, EventArgs.Empty);
                return false;
            }
            var encoding = new UTF8Encoding();
            var passwordBytes = encoding.GetBytes(password);

            var salt = Convert.FromBase64String(userAccount.Salt);
            
            var crypto = new MD5Crypto();
            crypto.Salt = salt;
            var hash = crypto.ComputeHash(passwordBytes, salt);

            var stringHash = Convert.ToBase64String(hash);
            

            if(Equals(stringHash, userAccount.Password))
            {
                user = new User(userAccount.UserRoleID,
                    userAccount.ID, userAccount.UserName, string.Empty, string.Empty, "Default");

                return true;
            }
            return false;        
        }
    }
}
