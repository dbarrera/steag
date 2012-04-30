using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public event EventHandler UserInActive;
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

        public UserAccount NewUserAccount()
        {
            return DataSession.NewUserAccount();
        }

        public UserAccount NewUserAccount(long roleID)
        {
            return DataSession.NewUserAccount(roleID);
        }

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

        public void DeleteUserAccount(UserAccount account)
        {

            if (Equals(account, null))
                throw new ArgumentNullException("account");

            DataSession.DeleteUserAccount(account);
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

            if (!userAccount.IsActive.Value)
            {
                if (!Equals(UserInActive, null))
                    UserInActive.Invoke(this, EventArgs.Empty);
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

        public bool IsUserPasswordValid(long userID, string password)
        {
            var userAccount = GetUserByID(userID);

            if (Equals(userAccount, null))
                return false;
            
            var encoding = new UTF8Encoding();
            var passwordBytes = encoding.GetBytes(password);

            var salt = Convert.FromBase64String(userAccount.Salt);

            var crypto = new MD5Crypto();
            crypto.Salt = salt;
            var hash = crypto.ComputeHash(passwordBytes, salt);

            var stringHash = Convert.ToBase64String(hash);


            return Equals(stringHash, userAccount.Password);
        }

        public void SetUserPassword(UserAccount userAccount, string password)
        {
            var crypto = new MD5Crypto();
            crypto.SaltSize = 64;
            crypto.SaltHash = true;

            var encoding = new UTF8Encoding();
            var passwordBytes = encoding.GetBytes(password);
            
            var hash = crypto.ComputeHash(passwordBytes);
            var salt = crypto.Salt;

            userAccount.Salt = Convert.ToBase64String(salt);
            userAccount.Password = Convert.ToBase64String(hash);
        }

        public void SetUserPassword(long userID, string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            var userAccount = GetUserByID(userID);
            if (Equals(userAccount, null))
                throw new Exception("User not found");

            SetUserPassword(userAccount, password);
        }

        public void SetUserPassword(long userID, string password, DateTime? dateChanged)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            var userAccount = GetUserByID(userID);
            if (Equals(userAccount, null))
                throw new Exception("User not found");

            SetUserPassword(userAccount, password);
            userAccount.LastPasswordChanged = dateChanged;
        }        

        public bool HasUserChangedPassword(long userID)
        {
            var user = GetUserByID(userID);
            if (Equals(user, null))
                return false;

            return !Equals(user.LastPasswordChanged, null);
        }


        public bool UsernameExists(string username)
        {
            if (Equals(username, null))
                throw new ArgumentNullException("username");

            return DataSession.UserNameExists(username);
        }

        public IEnumerable<UserAccount> GetUserAccountsByExpression(Expression<Func<UserAccount, bool>> expression)
        {
            return DataSession.GetUserAccountsByExpression(expression);
        }
        #endregion
    }
}
