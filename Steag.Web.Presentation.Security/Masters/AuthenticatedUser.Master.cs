using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Steag.Web.Presentation.Security.Masters
{
    public partial class AuthenticatedUser : Base.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserControl menuControl = null;

            if (CurrentUser.RoleID.Equals(5))
            {
                //Guard 3
                menuControl = (UserControl)Page.LoadControl("~\\Controls\\AdminMenuControl.ascx");
            }
            else if (CurrentUser.RoleID.Equals(6))
            {
                //Guard 1
                menuControl = (UserControl)Page.LoadControl("~\\Controls\\Guard1MenuControl.ascx");
            }
            else if (CurrentUser.RoleID.Equals(7))
            {
                //Guard 2
                menuControl = (UserControl)Page.LoadControl("~\\Controls\\Guard2MenuControl.ascx");
            }
            
            if(!Equals(menuControl, null))
                Menu.Controls.Add(menuControl);
        }
    }
}