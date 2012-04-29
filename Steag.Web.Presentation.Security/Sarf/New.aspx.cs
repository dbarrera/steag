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

namespace Steag.Web.Presentation.Security.Sarf
{
    public partial class New : Base.SecurePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {           
            
        }

        protected void AddSarfButton_Click(object sender, EventArgs e)
        {                   
            SARF sarfObj = SARFLogic.NewSARF();            
            
            sarfObj.DateFiled = SarfControl.dateFiledDatePicker.SelectedDate.Value;
            sarfObj.DateOfVisit = SarfControl.dateOfVisitDatePicker.SelectedDate.Value;
            sarfObj.FiledBy = CurrentUser.UserID;
            sarfObj.Purpose = SarfControl.purposeTextBox.Text;
            sarfObj.SourceIP = 
                Request.ServerVariables["REMOTE_ADDR"] ?? Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            
            sarfObj.Status = SarfControl.statusTextBox.Text;
            sarfObj.DateVisited = SarfControl.dateVisitedDatePicker.SelectedDate.Value;
            sarfObj.VisitVerifiedBy = 0;
            sarfObj.IsActive = true;           
            
            var sarfLogic = new SARFLogic(CurrentUser, NewDataSource());
            
            sarfLogic.AddSARF(sarfObj);
            sarfLogic.SubmitChanges();

        }
    }
}