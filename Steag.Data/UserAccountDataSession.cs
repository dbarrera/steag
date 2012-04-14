using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Steag.Framework.Model;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public class UserAccountDataSession: DataSession
    {
        public UserAccountDataSession(User user)
            :base(user)
        {                      
        }

        public UserAccountDataSession()
            : base()
        { 
        }

        public UserAccount GetUserByID(long id)
        {           
            return DataContext.UserAccount.SingleOrDefault( u => u.ID == id);
        }

        public UserAccount GetUserByUserName(string userName)
        {
            return DataContext.UserAccount.SingleOrDefault(u => u.UserName == userName);
        }

        public IEnumerable<UserAccount> GetAllUsers()
        { 
            return from u in DataContext.UserAccount select u;
        }

        public IEnumerable<UserAccount> GetAllUsers(bool isactive)
        {
            return from u in DataContext.UserAccount where u.IsActive == isactive select u;
        }

        public void AddUserAccount(UserAccount account)
        {
            DataContext.UserAccount.InsertOnSubmit(account);
        }

        public void AddUserAccounts(IEnumerable<UserAccount> accounts)
        {
            DataContext.UserAccount.InsertAllOnSubmit(accounts);
        }
    }
}
