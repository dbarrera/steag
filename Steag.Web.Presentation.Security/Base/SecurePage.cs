using System;
using System.Collections.Generic;
using System.Linq;
using Steag.Web.Base;
using Steag.Data;
using Steag.Framework.Authentication;

namespace Steag.Web.Presentation.Security.Base
{
    public abstract class SecurePage: Page
    {
        private bool _requiresAuthentication = true;

        public override string Description
        {
            get { return GetType().FullName; }
        }

        public override string Identity
        {
            get
            {
                return GetType().BaseType.FullName;
            }
        }

        public override string Theme
        {
            get
            {
                return CurrentUser.WebTheme;
            }
            set
            {
                CurrentUser.WebTheme = value;
            }
        }

        protected override bool RequiresAuthentication
        {
            get 
            { 
                return _requiresAuthentication; 
            }
            set 
            { 
                _requiresAuthentication = value; 
            }
        }

        protected virtual IDataSource NewDataSource()
        {
            return DataManager.CreateDefaultDataSource();
        }

        protected override void UserHasNoAccess(User user)
        {
            if (user.RoleID > 0)
                RedirectTo404();
            else
                RedirectToLogin();
        }

        protected virtual void RedirectToLogin()
        {
            if (!string.IsNullOrEmpty(Request.Url.PathAndQuery))
                Response.Redirect(string.Format("~/Login.aspx?returnUrl={0}", Server.UrlEncode(Request.Url.AbsoluteUri)));
            else
                Response.Redirect("~/Login.aspx");
        }

        protected virtual void RedirectTo404()
        {
            Response.Redirect("~/404.aspx");
        }
    }
}