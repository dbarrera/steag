using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Steag.Web.Base;

namespace Steag.Web.Presentation.Security
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserHandle.Current.ExpireUser();
            Response.Redirect("~/Login.aspx");
        }
    }
}