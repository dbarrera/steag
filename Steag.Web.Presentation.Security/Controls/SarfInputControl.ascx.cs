using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Steag.Web.Presentation.Security.Controls
{
    public partial class SarfInputControl : System.Web.UI.UserControl
    {
        public string SarfCode;

        public SarfInputControl()
        {
            SarfCode = string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SarfCodeLiteral.Text = SarfCode;
        }
    }
}