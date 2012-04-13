﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;

namespace Steag.Web.Base
{
    public abstract class Page : System.Web.UI.Page
    {
        public virtual User CurrentUser { get; protected set; }
    }
}
