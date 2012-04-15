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
        #region Events
        public event EventHandler UserNotFound;
        public event EventHandler InvalidPassword;
        #endregion

        #region DataSession
        private UserAccountDataSession _userAccountDataSession;

        protected override IDataSession CurrentDataSession
        {
            get { return DataSession; }
        }

        private UserAccountDataSession DataSession
        {
            get
            {
                _userAccountDataSession = _userAccountDataSession ?? new UserAccountDataSession(CurrentUser, CurrentDataSource);
                return _userAccountDataSession;
            }
        }
        #endregion

        #region Constructor
        public UserAccountLogic(User user, IDataSource dataSource)
            :base(user, dataSource)
        {
        }

        public UserAccountLogic(IDataSource dataSource)
            :base(dataSource)
        {             
        }
        #endregion

        #region Methods

        public UserAccount GetUserByID(long id)
        {
            return DataSession.GetUserByID(id);
        }

        public UserAccount GetUserByUserName(string userName)
        {
            return DataSession.GetUserByUserName(userName);
        }

        public IEnumerable<UserAccount> GetAllUsers()
        {
            
            return DataSession.GetAllUsers();
        }

        public IEnumerable<UserAccount> GetAllUsers(bool isActive)
        {            
            return DataSession.GetAllUsers(isActive);   
        }

        public void AddUserAccount(UserAccount userAccount)
        {
            if (Equals(userAccount, null))
                throw new ArgumentNullException("userAccount");

            DataSession.AddUserAccount(userAccount);
        }

        public void AddUserAccounts(IEnumerable<UserAccount> accounts)
        {
            if (Equals(accounts, null))
                throw new ArgumentNullException("accounts");

            DataSession.AddUserAccounts(accounts);
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

            if (!Equals(InvalidPassword, null))
                InvalidPassword.Invoke(this, EventArgs.Empty);
            
            return false;
        }

        #endregion
    }
}
