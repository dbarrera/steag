using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public abstract class DataSession
    {
        public virtual User CurrentUser { get; protected set; }

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

        protected DataSession(User user)
        {
            CurrentUser = user;
        }
    }
}
