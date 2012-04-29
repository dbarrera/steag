using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Steag.Business;

namespace Steag.Web.Presentation.Security.UserAccount
{
    public partial class Register : Base.SecurePage
    {        

        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!IsPostBack)
            {
                cboUserRole.SelectedIndex = 3;
            }
        }

        protected virtual void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            using (var userAccountLogic = new UserAccountLogic(NewDataSource()))
            {
                var user = userAccountLogic.NewUserAccount();
                user.UserName = txtUsername.Text.Trim();

                //Set Password
                userAccountLogic.SetUserPassword(user, txtPassword.Text);
                //
                
                user.UserRoleID = long.Parse(cboUserRole.SelectedValue);
                user.FirstName = txtFirstName.Text;
                user.MiddleName = txtMiddleName.Text ?? string.Empty;
                user.LastName = txtLastName.Text;
                user.EmailAddress = txtEmailAddress.Text ?? string.Empty;

                userAccountLogic.AddUserAccount(user);

                userAccountLogic.SubmitChanges();                
            }
            Response.Redirect("~/UserAccount/UserManagement.aspx");
        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserAccount/UserManagement.aspx");
        }

        protected virtual void valConfirmPassword_Validate(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = Equals(txtPassword.Text, txtConfirmPassword.Text);            
        }

        protected virtual void valCheckUsername_Validate(object sender, ServerValidateEventArgs e)
        {
            using (var userAccountLogic = new UserAccountLogic(NewDataSource()))
            {
                e.IsValid = !userAccountLogic.UsernameExists(txtUsername.Text ?? string.Empty);
            }            
        }
    }
}