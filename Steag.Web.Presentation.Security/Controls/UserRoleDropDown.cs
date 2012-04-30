using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Steag.Framework.Model;
using Steag.Business;

namespace Steag.Web.Presentation.Security.Controls
{
    public class UserRoleDropDown: Telerik.Web.UI.RadComboBox
    {
        public enum UserRoleType { 
            AllUserRoles,
            ActiveUserRolesOnly,
            TemplateOnly,
            All
        }

        private UserRoleType _userRoleType = UserRoleType.ActiveUserRolesOnly;

        public UserRoleType RoleType 
        {
            get
            {
                return _userRoleType;
            }
            set 
            {
                _userRoleType = value;
            }
        }

        protected override void OnLoad(EventArgs e)
        {           
 
            base.OnLoad(e);

            if (Page.IsPostBack)
                return;

            IEnumerable<UserRole> dataSource;

            if (RoleType == UserRoleType.ActiveUserRolesOnly)
                dataSource = UserRoleLogic.UserRoleHandler.GetActiveUserRoles();
            else if (RoleType == UserRoleType.AllUserRoles)
                dataSource = UserRoleLogic.UserRoleHandler.GetUserRoles();
            else if (RoleType == UserRoleType.TemplateOnly)
                dataSource = UserRoleLogic.UserRoleHandler.GetTemplateRoles();
            else if (RoleType == UserRoleType.AllUserRoles)
                dataSource = UserRoleLogic.UserRoleHandler.GetAllRoles();
            else
                dataSource = UserRoleLogic.UserRoleHandler.GetActiveUserRoles();
            var x = new UserRole();
            
            
            DataTextField = "RoleCode";
            DataValueField = "ID";
            DataSource = dataSource;
            DataBind();
        }
    }
}