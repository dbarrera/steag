using System;
using System.Collections.Generic;
using System.Linq;

namespace Steag.Web.Presentation.Security.Base
{
    public abstract class RegularPage: Steag.Web.Base.Page
    {
        public override string Description
        {
            get { return GetType().FullName; }
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
    }
}