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

        protected DataSession(User user)
        {
            CurrentUser = user;
        }
    }
}
