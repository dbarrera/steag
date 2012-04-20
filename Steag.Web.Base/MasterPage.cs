using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;

namespace Steag.Web.Base
{
    public class MasterPage : System.Web.UI.MasterPage
    {
        public virtual User CurrentUser
        {
            get { return UserHandle.Current.CurrentUser; }
        }
    }
}
