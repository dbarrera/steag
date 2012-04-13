using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Steag.Framework.Configuration
{
    public class SteagConfiguration: ConfigurationSection
    {
        [ConfigurationProperty("ConnectionStringKey", IsRequired = true)]
        public string ConnectionStringKey
        {
            get
            {
                return (string)this["ConnectionStringKey"];
            }
            set
            {
                this["ConnectionStringKey"] = value;
            }
        }

        [ConfigurationProperty("MappingSource", IsRequired = true)]
        public string MappingSource
        {
            get
            {
                return (string)this["MappingSource"];
            }
            set
            {
                this["MappingSource"] = value;
            }
        }
    }
}
