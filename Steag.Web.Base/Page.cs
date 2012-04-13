using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework;
using Steag.Framework.Authentication;
using Steag.Business.Handler;

namespace Steag.Web.Base
{
    public abstract class Page : System.Web.UI.Page, IIdentifiable
    {
        public virtual User CurrentUser
        {
            get { return UserHandle.Current.CurrentUser; }
        }

        public string Identity
        {
            get { return GetType().FullName; }
        }

        protected override void OnPreInit(EventArgs e)
        {
            var hasAccess = SystemAccessHandler.Current.HasAccess(CurrentUser.RoleID, Identity);
            if(!hasAccess)
            {
                //Redirect page

            }
            base.OnPreInit(e);
        }

        private Framework.Event.EventDispatcher EventDispatcher
        {
            get { return Framework.Event.EventDispatcher.Current; }
        }

        protected void RaiseEvent(string eventName, EventArgs e)
        {
            EventDispatcher.RaiseEvent(eventName, this, e);
        }

        protected void RaiseEvent(string eventName, object sender, EventArgs e)
        {
            EventDispatcher.RaiseEvent(eventName, sender, e);
        }
    }
}
