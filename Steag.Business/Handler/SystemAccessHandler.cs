using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;

namespace Steag.Business.Handler
{
    public class SystemAccessHandler: ISystemAccessHandler
    {
        private static ISystemAccessHandler _accessHandler;

        public bool HasAccess(Int64 roleID, string identity)
        {
            return true;
        }

        public static ISystemAccessHandler Current
        {
            get { _accessHandler = _accessHandler ?? new SystemAccessHandler();
                return _accessHandler;
            }
        }

        public static void SetCurrentSystemAccessHandler(ISystemAccessHandler handler)
        {
            _accessHandler = handler;
        }
    }
}
