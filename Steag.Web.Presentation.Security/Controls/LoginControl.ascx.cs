using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Steag.Web.Presentation.Security.Controls
{
    public class LoginEventArgs : EventArgs
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }

    public partial class LoginControl : Steag.Web.Base.Control
    {
        public event EventHandler Login;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Equals(Login, null))
            {
                var args = new LoginEventArgs { UserName = txtUserName.Text, Password = txtPassword.Text };
                Login.Invoke(sender, args);
            }
        }

        public void SetErrorMessage(string message)
        {
            txtError.Text = message;
        }
    }
}