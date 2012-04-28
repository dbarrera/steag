using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Steag.Web.Presentation.Security.Controls
{
    public partial class PasswordEntryControl : System.Web.UI.UserControl
    {
        public bool IsPasswordMatch
        {
            get
            {
                return txtPassword.Text.Equals(txtConfirmPassword.Text);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}