using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Model;

namespace Steag.Business.Handler
{
    public interface IUserRoleHandler
    {
        IEnumerable<UserRole> GetActiveUserRoles();

        IEnumerable<UserRole> GetUserRoles();

        IEnumerable<UserRole> GetTemplateRoles();

        IEnumerable<UserRole> GetAllRoles();
    }
}
