using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Steag.Web.Base;
using Steag.Web.Presentation.Security.Controls;
using Steag.Business;
using Steag.Framework.Authentication;

namespace Steag.Web.Presentation.Security
{
    public partial class Login : Base.RegularPage
    {
        public override string Description
        {
            get { return "STEAG Security System Login Page"; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginControl_Login(object sender, EventArgs e)
        {
            var args = e as LoginEventArgs;
            User user = null;

            var userAccountLogic = new UserAccountLogic();
            userAccountLogic.UserNotFound += UserNotFound;
            var allowLogin = userAccountLogic.AllowLogin(args.UserName, args.Password, ref user);

            if (allowLogin)
            {
                UserHandle.Current.CurrentUser = user;
                //Response.Redirect("");
            }
            else
            { 
                //Invalid Password
            }
        }

        protected void UserNotFound(object sender, EventArgs e)
        { 
            // UserNotFound
        }
    }
}