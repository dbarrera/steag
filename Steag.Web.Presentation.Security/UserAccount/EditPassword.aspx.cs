using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Steag.Web.Base;
using System.Web.UI.WebControls;
using Steag.Business;

namespace Steag.Web.Presentation.Security.UserAccount
{
    public partial class EditPassword : Base.SecurePage
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
            
            divOldPassword.Visible = CurrentUser.UserID == UserID;

        }

        protected virtual void valConfirmPassword_Validate(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = Equals(txtPassword.Text, txtConfirmPassword.Text);
        }

        protected virtual void valCheckOldPassword_Validate(object sender, ServerValidateEventArgs e)
        {
            using (var userAccountLogic = new UserAccountLogic(NewDataSource()))
            {
                e.IsValid = userAccountLogic.IsUserPasswordValid(UserID, txtOldPassword.Text ?? string.Empty);
            }
        }

        protected virtual void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            using (var userAccountLogic = new UserAccountLogic(CurrentUser, NewDataSource()))
            {                
                if(CurrentUser.UserID == UserID)
                    userAccountLogic.SetUserPassword(UserID, txtPassword.Text, DateTime.Now);
                else
                    userAccountLogic.SetUserPassword(UserID, txtPassword.Text, null);
                userAccountLogic.SubmitChanges();
            }

            if (CurrentUser.UserID == UserID)
                Logout();

            Response.Redirect("~/UserAccount/UserManagement.aspx");
        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            if (CurrentUser.RoleID != 5)
                Response.Redirect("~/UserHome.aspx");
            Response.Redirect("~/UserAccount/UserManagement.aspx");
        }

        protected virtual void Logout()
        {
            UserHandle.Current.ExpireUser();
            Response.Redirect("~/Login.aspx");
        }
    }
}