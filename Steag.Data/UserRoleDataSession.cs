using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;
using Steag.Framework.Model;

namespace Steag.Data
{
    public class UserRoleDataSession: DataSession
    {

        public UserRoleDataSession(IDataSource dataSource)
            : base(dataSource)
        { 
        }

        public UserRoleDataSession(User user, IDataSource dataSource)
            : base(user, dataSource)
        {
        }

        public IEnumerable<UserRole> GetActiveUserRoles()
        {
            var activeRoles = from u in DataContext.UserRole where !u.IsTemplate && u.IsActive.Value select u;
            return activeRoles;
        }

        public IEnumerable<UserRole> GetUserRoles()
        {
            var userRoles = from u in DataContext.UserRole where !u.IsTemplate select u;
            return userRoles;
        }

        public IEnumerable<UserRole> GetTemplateRoles()
        {
            var templateRoles = from u in DataContext.UserRole where u.IsTemplate select u;
            return templateRoles;
        }

        public IEnumerable<UserRole> GetAllRoles()
        {
            var all = from u in DataContext.UserRole select u;
            return all;
        }
    }
}
