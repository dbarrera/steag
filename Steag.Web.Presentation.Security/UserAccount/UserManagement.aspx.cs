using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Steag.Business;

namespace Steag.Web.Presentation.Security.UserAccount
{
    public partial class UserManagement : Base.SecurePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                using(var userAccountLogic = new UserAccountLogic(NewDataSource()))
                {
                    var users = userAccountLogic.GetAllUsers();
                    gridUsers.DataSource = users;
                    gridUsers.DataBind();
                }               
            }
        }

        protected void gridUsers_SortCommand(object sender, Telerik.Web.UI.GridSortCommandEventArgs e)
        {
            using (var userAccountLogic = new UserAccountLogic(NewDataSource()))
            {
                var users = userAccountLogic.GetAllUsers();      
                gridUsers.DataSource = users;
                gridUsers.DataBind();
            } 
        }

        protected virtual string GetUserRoleCode(long roleID)
        {
            if (roleID == 5)
                return "Administrator";
            else if (roleID == 6)
                return "Gate 1 Guard";            
            else if (roleID == 7)
                return "Gate 2 Guard";            
            return "Employee";            
        }
    }
}