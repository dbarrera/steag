using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Steag.Business.Handler;

namespace Steag.Web.Presentation.Security.Authentication
{
    public class SteagSystemAccessHandler: ISystemAccessHandler
    {
        public bool HasAccess(Int64 roleID, string identity)
        {
            if (roleID == 5)
            { 
                return true;
            }
            else if (roleID == 6)
            {
                return IsGuard1HasAcess(identity);
            }
            else if (roleID == 7)
            {
                return IsGuard2HasAccess(identity);
            }
            return false;
        }

        private bool IsGuard1HasAcess(string identity)
        {
            return true;
        }

        private bool IsGuard2HasAccess(string identity)
        {
            return true;
        }

        

    }
}