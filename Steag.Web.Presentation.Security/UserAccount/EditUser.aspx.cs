using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Steag.Business;

namespace Steag.Web.Presentation.Security.UserAccount
{
    public partial class EditUser : Base.SecurePage
    {
        protected virtual long UserID
        {
            get
            {
                long id = 0;
                long.TryParse(Request.QueryString["id"], out id);

                if (id == 0 || CurrentUser.RoleID != 5)
                    id = CurrentUser.UserID;

                return id;
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserID < 1)
            {
                if (CurrentUser.RoleID != 5)
                    Response.Redirect("~/UserHome.aspx");
                Response.Redirect("~/UserAccount/UserManagement.aspx");
            }

            if (IsPostBack)
                return;


            if (CurrentUser.RoleID != 5)
            {
                cboUserRole.Enabled = false;
                cboActive.Enabled = false;
            }

            using (var userAccountLogic = new UserAccountLogic(NewDataSource()))
            {
                var user = userAccountLogic.GetUserByID(UserID);

                if (Equals(user, null))
                {
                    if (CurrentUser.RoleID != 5)
                        Response.Redirect("~/UserHome.aspx");
                    Response.Redirect("~/UserAccount/UserManagement.aspx");
                }

                txtUsername.Text = user.UserName;
                txtFirstName.Text = user.FirstName;
                txtMiddleName.Text = user.MiddleName;
                txtLastName.Text = user.LastName;
                txtEmailAddress.Text = user.EmailAddress;

                switch (user.UserRoleID)
                {
                    case 5:
                        cboUserRole.SelectedIndex = 0;
                        break;
                    case 6:
                        cboUserRole.SelectedIndex = 1;
                        break;
                    case 7:
                        cboUserRole.SelectedIndex = 2;
                        break;
                    case 8:
                        cboUserRole.SelectedIndex = 3;
                        break;
                }

                if (user.IsActive ?? false)
                    cboActive.SelectedIndex = 0;
                else
                    cboActive.SelectedIndex = 1;
            }
        }

        protected virtual void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            using (var userAccountLogic = new UserAccountLogic(CurrentUser, NewDataSource()))
            {
                var user = userAccountLogic.GetUserByID(UserID);

                if (Equals(user, null))
                {
                    if (CurrentUser.RoleID != 5)
                        Response.Redirect("~/UserHome.aspx");
                    Response.Redirect("~/UserAccount/UserManagement.aspx");
                }
             
                user.UserRoleID = long.Parse(cboUserRole.SelectedValue);
                user.FirstName = txtFirstName.Text;
                user.MiddleName = txtMiddleName.Text ?? string.Empty;
                user.LastName = txtLastName.Text;
                user.EmailAddress = txtEmailAddress.Text ?? string.Empty;
                if (cboActive.SelectedValue == "Active")
                    user.IsActive = true;
                else
                    user.IsActive = false;

                userAccountLogic.SubmitChanges();
            }

            if(CurrentUser.RoleID != 5)
                Response.Redirect("~/UserHome.aspx");
            Response.Redirect("~/UserAccount/UserManagement.aspx");
        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            if (CurrentUser.RoleID != 5)
                Response.Redirect("~/UserHome.aspx");
            Response.Redirect("~/UserAccount/UserManagement.aspx");
        }
    }
}