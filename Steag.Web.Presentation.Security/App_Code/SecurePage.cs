using System;
using System.Collections.Generic;
using System.Linq;
using Steag.Web.Base;

namespace Steag.Web.Presentation.Security
{
    public class SecurePage: Page
    {
        private bool _requiresAuthentication = true;

        public overrides bool RequiresAuthentication
        {
            get { return _requiresAuthentication; }
            set { _requiresAuthentication = value; }
        }
    }
}