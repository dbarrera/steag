using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;
using Steag.Data;
using Steag.Business.Handler;
using Steag.Framework.Model;

namespace Steag.Business
{
    public class UserRoleLogic: LogicBase, IUserRoleHandler
    {
        private static IUserRoleHandler _userRoleLogic;

        private UserRoleDataSession _userRoleDataSession;

        protected override IDataSession CurrentDataSession
        {
            get 
            {
                return DataSession;
            }
        }

        private UserRoleDataSession DataSession
        {
            get
            {
                _userRoleDataSession = _userRoleDataSession ?? new UserRoleDataSession(CurrentUser, CurrentDataSource);
                return _userRoleDataSession;
            }
        }

        #region Constructor
        public UserRoleLogic(User user, IDataSource dataSource)
            :base(user, dataSource)
        {
        }

        public UserRoleLogic(IDataSource dataSource)
            :base(User.Default, dataSource)
        {             
        }
        #endregion

        #region IUserRoleHandler
        public IEnumerable<UserRole> GetActiveUserRoles()
        {
            return DataSession.GetActiveUserRoles();
        }


        public IEnumerable<UserRole> GetUserRoles()
        {
            return DataSession.GetUserRoles();
        }

        public IEnumerable<UserRole> GetTemplateRoles()
        {
            return DataSession.GetTemplateRoles();
        }

        public IEnumerable<UserRole> GetAllRoles()
        {
            return DataSession.GetAllRoles();
        }
        #endregion

        #region Singleton
        public static IUserRoleHandler UserRoleHandler
        {
            get
            {
                _userRoleLogic = _userRoleLogic ?? new UserRoleLogic(Steag.Data.DataManager.CreateDefaultDataSource());
                return _userRoleLogic;
            }
        }

        public static void SetUserRoleHandler(IUserRoleHandler userRoleLogic)
        {
            _userRoleLogic = userRoleLogic;
        }
        #endregion

    }
}
