using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Model
{
    public class UserAccount: EntityBase
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string PasswordIV { get; set; }

        public string PasswordSalt { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public int UserRoleID { get; set; }

        public UserRole UserRole { get; set; }
                
    }
}
