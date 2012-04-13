using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Model.PageSecurity
{
    public class Page: EntityBase
    {
        public string PageName { get; set; }

        public string Description { get; set; }
    }
}
