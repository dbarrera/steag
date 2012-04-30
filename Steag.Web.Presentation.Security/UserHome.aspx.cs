using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Steag.Business;

namespace Steag.Web.Presentation.Security
{
    public partial class UserHome : Base.SecurePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var userAccountLogic = new UserAccountLogic(NewDataSource()))
            {
                if (!userAccountLogic.HasUserChangedPassword(CurrentUser.UserID))
                    Response.Redirect("~/UserAccount/EditPassword.aspx");
            }
        }
    }
}