using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace Steag.Web.Presentation.Security.Controls
{
    public class MenuControl : Steag.Web.Base.Control
    {
        protected global::Telerik.Web.UI.RadMenu mnuAdmin;
        protected global::Telerik.Web.UI.RadSiteMap BreadCrumbSiteMap;

        protected void Page_Load(object sender, EventArgs e)
        {
            var currentItem = mnuAdmin.FindItemByUrl(Request.Url.PathAndQuery);
            if (currentItem != null)
            {
                currentItem.HighlightPath();
                DataBindBreadCrumbSiteMap(currentItem);
            }
            else
                mnuAdmin.Items[0].HighlightPath();
        }

        private void DataBindBreadCrumbSiteMap(RadMenuItem currentItem)
        {
            List<RadMenuItem> breadCrumbPath = new List<RadMenuItem>();
            while (currentItem != null)
            {
                breadCrumbPath.Insert(0, currentItem);
                currentItem = currentItem.Owner as RadMenuItem;
            }
            BreadCrumbSiteMap.DataSource = breadCrumbPath;
            BreadCrumbSiteMap.DataBind();
        }
    }
}