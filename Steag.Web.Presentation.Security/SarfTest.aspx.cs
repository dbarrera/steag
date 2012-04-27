using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Steag.Web.Presentation.Security;
using Steag.Web.Presentation.Security.Controls;
using Steag.Business;
using Steag.Framework.Model;

namespace Steag.Web.Presentation.Security
{
    public partial class SarfTest : Base.SecurePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //var logic = new SarfLogic(CurrentUser, NewDataSource());   
        }

        protected void AddSarfButton_Click(object sender, EventArgs e)
        {
            
            var dataSource = NewDataSource();
            //var systemSettings = new Sys
            var currentAccount = new UserAccountLogic(CurrentUser, dataSource);
            var user = currentAccount.GetUserByID(CurrentUser.UserID);
            SARF sarfObj = new SARF();
            
            sarfObj.DateFiled = SarfControl.dateFiledDatePicker.SelectedDate.Value;
            sarfObj.DateOfVisit = SarfControl.dateOfVisitDatePicker.SelectedDate.Value;
            sarfObj.FiledBy = user.ID;
            sarfObj.Purpose = SarfControl.purposeTextBox.Text;
            sarfObj.SourceIP = Request.ServerVariables["REMOTE_ADDR"] ?? Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            sarfObj.Status = SarfControl.statusTextBox.Text;
            sarfObj.DateVisited = SarfControl.dateVisitedDatePicker.SelectedDate.Value;
            sarfObj.VisitVerifiedBy = 0;
            sarfObj.IsActive = true;
            sarfObj.UserCreated = user.ID;
            sarfObj.DateCreated = DateTime.Now;

            var sarfEntry = new SarfLogic(CurrentUser, dataSource);
            sarfEntry.AddSarf(sarfObj);
        }
    }
}