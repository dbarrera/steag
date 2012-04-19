using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;
using System.Web;

namespace Steag.Web.Base
{
    public class UserHandle: IUserHandle
    {
        private const string USER_SESSION_IDENTITY = "86E5C2B4-A3F9-4694-8126-EBB6C7702DFF";
        private const string DEFAULT_THEME = "Default";
        private static IUserHandle _userHandle;        

        public User CurrentUser
        {             
            get
            {
                var user = HttpContext.Current.Session[USER_SESSION_IDENTITY];
                if (Equals(user, null))
                    user = CreateDefaultUser();

                return (typeof(User).IsAssignableFrom(user.GetType())) ?
                    user as User : CreateDefaultUser();
            }
            set
            {
                HttpContext.Current.Session[USER_SESSION_IDENTITY] = value;
            }
        }

        private User CreateDefaultUser()
        {
            return new User(0, 0, "Guest", "guest@steag.com", string.Empty, DEFAULT_THEME);
        }

        public void ExpireUser()
        {
            CurrentUser = null;
        }

        private UserHandle()
        {
        }

        #region Singleton

        #region Current
        /// <summary>
        /// UserHandle Singleton Instance
        /// </summary>
        public static IUserHandle Current
        {
            get
            {
                _userHandle = _userHandle ?? new UserHandle();
                return _userHandle;
            }
        }
        #endregion

        /// <summary>
        /// Set Singleton UserHandle
        /// </summary>
        /// <param name="userhandle"></param>
        public static void SetUserHandle(IUserHandle userhandle)
        {
            _userHandle = userhandle;
        }
        #endregion

    }
}
