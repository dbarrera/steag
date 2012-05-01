using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Steag.Business;
using Steag.Web.Presentation.Security.Controls;

namespace Steag.Web.Presentation.Security.UserAccount
{
    public partial class UserManagement : Base.SecurePage
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            searchControl.Search += searchControl_Search;

            if (IsPostBack)
                return;

            var searchKeys = new string[] { 
                "Username",
                "First Name",
                "Last Name"};

            searchControl.KeyDataSource = searchKeys;

            using(var userAccountLogic = new UserAccountLogic(NewDataSource()))
            {
                var users = userAccountLogic.GetUserAccountsByExpression(u => u.IsActive);
                gridUsers.DataSource = users;
                gridUsers.DataBind();
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

        protected virtual void searchControl_Search(object sender, SearchControl.SearchEventArgs e)
        {
            Expression<Func<Steag.Framework.Model.UserAccount, bool>> deg = u => u.ID == u.ID;


            if (cboFilter.SelectedValue == "All")
            {
                switch (e.SearchKey)
                {
                    case "Username":
                        deg = u => u.UserName.Contains(e.SearchValue.Trim());
                        break;
                    case "First Name":
                        deg = u => u.FirstName.Contains(e.SearchValue.Trim());
                        break;
                    case "Last Name":
                        deg = u => u.LastName.Contains(e.SearchValue.Trim());
                        break;
                }
            }
            else if(cboFilter.SelectedValue == "Active")
            {
                switch (e.SearchKey)
                {
                    case "Username":
                        deg = u => u.UserName.Contains(e.SearchValue.Trim()) && u.IsActive;
                        break;
                    case "First Name":
                        deg = u => u.FirstName.Contains(e.SearchValue.Trim()) && u.IsActive;
                        break;
                    case "Last Name":
                        deg = u => u.LastName.Contains(e.SearchValue.Trim()) && u.IsActive;
                        break;
                }
            }
            else if (cboFilter.SelectedValue == "InActive")
            {
                switch (e.SearchKey)
                {
                    case "Username":
                        deg = u => u.UserName.Contains(e.SearchValue.Trim()) && !u.IsActive;
                        break;
                    case "First Name":
                        deg = u => u.FirstName.Contains(e.SearchValue.Trim()) && !u.IsActive;
                        break;
                    case "Last Name":
                        deg = u => u.LastName.Contains(e.SearchValue.Trim()) && !u.IsActive;
                        break;
                }
            }
            using (var userAccountLogic = new UserAccountLogic(NewDataSource()))
            {
                var users = userAccountLogic.GetUserAccountsByExpression(deg);
                gridUsers.DataSource = users;
                gridUsers.DataBind();
            } 
        }

        protected void cboFilter_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            using (var userAccountLogic = new UserAccountLogic(NewDataSource()))
            {
                IEnumerable<Steag.Framework.Model.UserAccount> users;

                if (cboFilter.SelectedValue == "All")
                    users = userAccountLogic.GetAllUsers();
                else if (cboFilter.SelectedValue == "Active")
                    users = userAccountLogic.GetUserAccountsByExpression(u => u.IsActive);
                else
                    users = userAccountLogic.GetUserAccountsByExpression(u => !u.IsActive);
                
                gridUsers.DataSource = users;
                gridUsers.DataBind();
            }

        }
    }
}