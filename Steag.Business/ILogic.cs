using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;

namespace Steag.Business
{
    public interface ILogic
    {
        User CurrentUser { get; }
    }
}
