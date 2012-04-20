using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;

namespace Steag.Web.Base
{
    public abstract class Control: System.Web.UI.UserControl
    {
        public virtual User CurrentUser
        {
            get { return UserHandle.Current.CurrentUser; }
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
