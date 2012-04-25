using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Steag.Web.Presentation.Security;
using Steag.Business;

namespace Steag.Web.Presentation.Security
{
    public partial class SarfTest : Base.SecurePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var logic = new SarfLogic(CurrentUser, NewDataSource());
        }
    }
}