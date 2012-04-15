using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Authentication
{
    public class User: IDisposable
    {
        private static User _user;

        public Int64 RoleID { get; private set; }

        public Int64 UserID { get; private set; }

        public string UserName { get; private set; }

        public string EmailAddress { get; private set; }

        public string Theme { get; set; }

        public string WebTheme { get; set; }

        public User(Int64 roleID, 
            Int64 userID, 
            string userName,
            string emailAddress,
            string theme,
            string webtheme)
        {
            RoleID = roleID;
            UserID = userID;
            UserName = userName;
            EmailAddress = emailAddress;
            Theme = theme;
            WebTheme = webtheme;
        }

        
        public static User Default
        {
            get
            {
                _user = _user ?? new User(0, 0, string.Empty, string.Empty, string.Empty, string.Empty);
                return _user;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                UserName = null;
                EmailAddress = null;
                Theme = null;
                WebTheme = null;
            }
        }
    }
}
