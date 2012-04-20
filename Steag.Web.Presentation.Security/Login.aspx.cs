using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Steag.Web.Base;
using Steag.Web.Presentation.Security.Controls;
using Steag.Business;
using Steag.Data;
using Steag.Framework.Authentication;

namespace Steag.Web.Presentation.Security
{
    public partial class Login : Base.RegularPage
    {
        public override string Description
        {
            get { return "STEAG Security Management System Login Page"; }
        }

        private string ReturnUrl
        {
            get
            {
                var returnUrl = Request.QueryString["returnUrl"];
                return Equals(returnUrl, null) ? string.Empty : returnUrl;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD




=======
            if (CurrentUser.RoleID > 0)
            {
                Response.Redirect("UserHome.aspx");
            }
>>>>>>> 656b9ba31b798d6ce6e3c0bd172a97826ddcc4fc
        }

        protected void loginControl_Login(object sender, EventArgs e)
        {    
            RaiseEvent("Login.aspx#Login", sender, e);

            var args = e as LoginEventArgs;
            User user = null;
            bool allowLogin;          
            
            using (var dataSource = NewDataSource())
            {                
                using (var userAccountLogic = new UserAccountLogic(dataSource))
                {
                    userAccountLogic.UserNotFound += UserNotFound;
                    userAccountLogic.InvalidPassword += InvalidPassword;

                    allowLogin = userAccountLogic.AllowLogin(args.UserName, args.Password, ref user);
                }
            }

            if (allowLogin)
            {
                UserHandle.Current.CurrentUser = user;
                RaiseEvent("Login.aspx#LoginSuccessful", sender, e);
                if (!string.IsNullOrEmpty(ReturnUrl))
                    Response.Redirect(string.Format("{0}",ReturnUrl));
                Response.Redirect("UserHome.aspx");
            }
        }

        protected void UserNotFound(object sender, EventArgs e)
        {
            RaiseEvent("Login.aspx#UserNotFound", sender, e);
            loginControl.SetErrorMessage("User not found");
            
        }

        protected void InvalidPassword(object sender, EventArgs e)
        {
            RaiseEvent("Login.aspx#InvalidPassword", sender, e);
            loginControl.SetErrorMessage("Invalid Password");
        }
    }
}