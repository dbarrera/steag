using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Steag.Web.Presentation.Security.Controls
{
    public partial class SearchControl : Steag.Web.Base.Control
    {
        public delegate void SearchEventDelegate(object sender, SearchEventArgs e);

        public class SearchEventArgs: EventArgs
        {
            public string SearchKey { get; set; }
            public string SearchValue { get; set; }
        }

        public SearchEventDelegate Search;

        public object KeyDataSource
        {
            get
            {
                return cboKey.DataSource;
            }
            set
            {
                cboKey.DataSource = value;
            }
        }

        public string KeyDataValueField
        {
            get
            {
                return cboKey.DataValueField;
            }
            set
            {
                cboKey.DataValueField = value;
            }
        }

        public string KeyDataTextField
        {
            get
            {
                return cboKey.DataTextField;
            }
            set
            {
                cboKey.DataTextField = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            cboKey.DataBind();            
        }

        protected virtual void btnSearch_Click(object sender, EventArgs e)
        {
            if (!Equals(Search, null))
            { 
                var args = new SearchEventArgs(){SearchKey = cboKey.SelectedValue, SearchValue = txtSearch.Text};
                Search(this, args);
            }
        }
    }
}