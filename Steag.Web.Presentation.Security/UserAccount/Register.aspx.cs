using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            if (!valConfirmPassword.IsValid)
                return;
        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserAccount/UserManagement.aspx");
        }


        protected virtual void valConfirmPassword_Validate(object sender, ServerValidateEventArgs e)
        {            
            valConfirmPassword.IsValid = txtPassword.IsPasswordMatch;
        }
    }
}