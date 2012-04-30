using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Steag.Business.Handler;

namespace Steag.Web.Presentation.Security.Authentication
{
    public class SteagSystemAccessHandler: ISystemAccessHandler
    {
        private static List<string> _guard1AccessList;
        private static List<string> _guard2AccessList;

        private static List<string> Guard1AccessList
        {
            get
            { 
                _guard1AccessList = _guard1AccessList ?? new List<string>();
                return _guard1AccessList;
            }
        }

        private static List<string> Guard2AccessList
        {
            get
            {
                _guard2AccessList = _guard2AccessList ?? new List<string>();
                return _guard2AccessList;
            }
        }

        static SteagSystemAccessHandler()
        {
            AddAdministratorAccess();
            AddGuard1Access();
            AddGuard2Access();
        }

        private static void AddAdministratorAccess()
        { 
            //Leave this blank because Administrator have access to all
        }

        private static void AddGuard1Access()
        {
            Guard1AccessList.Add("Steag.Web.Presentation.Security.UserHome");
            Guard1AccessList.Add("Steag.Web.Presentation.Security.Sarf.New");
            Guard1AccessList.Add("Steag.Web.Presentation.Security.UserAccount.EditUser");
            Guard1AccessList.Add("Steag.Web.Presentation.Security.UserAccount.EditPassword");
        }

        private static void AddGuard2Access()
        {
            Guard2AccessList.Add("Steag.Web.Presentation.Security.UserHome");
            Guard2AccessList.Add("Steag.Web.Presentation.Security.UserAccount.EditUser");
            Guard2AccessList.Add("Steag.Web.Presentation.Security.UserAccount.EditPassword");
        }

        public bool HasAccess(Int64 roleID, string identity)
        {
            if (roleID == 5)
            { 
                //Administrator has access to all
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
            var result = Guard1AccessList.SingleOrDefault(x => x == identity);
            return !string.IsNullOrEmpty(result);
        }

        private bool IsGuard2HasAccess(string identity)
        {
            var result = Guard2AccessList.SingleOrDefault(x => x == identity);
            return !string.IsNullOrEmpty(result);
        }

        

    }
}