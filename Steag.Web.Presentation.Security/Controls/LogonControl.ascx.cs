using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Steag.Web.Presentation.Security.Controls
{
    public partial class LogonControl : Steag.Web.Base.Control
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUser.Text = CurrentUser.UserName;
        }
    }
}