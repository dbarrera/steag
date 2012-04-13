using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;

namespace Steag.Business
{
    public abstract class LogicBase
    {
        public virtual User CurrentUser { get; protected set; }

        protected LogicBase(User user)
        {
            CurrentUser = user;
        }
    }
}
