using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;

namespace Steag.Web.Base
{
    public interface IUserHandle
    {
        User CurrentUser { get; set; }
    }
}
