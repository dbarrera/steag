using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Steag.Framework.Configuration
{
    public class SteagConfiguration: ConfigurationSection
    {
        private static SteagConfiguration _steageConfiguration;

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

        [ConfigurationProperty("LogFileFolder", IsRequired = false)]
        public string LogFileFolder
        {
            get
            {
                return (string)this["LogFileFolder"];
            }
            set
            {
                this["LogFileFolder"] = value;
            }
        }

        public static SteagConfiguration Default
        {
            get
            {
                if (Equals(_steageConfiguration, null))
                {
                    var section = System.Configuration.ConfigurationManager.GetSection("Steag.Security");

                    if (Equals(section, null))
                    {
                        _steageConfiguration = new SteagConfiguration
                        { 
                            ConnectionStringKey = "Default",
                            MappingSource = "Configuration\\datasource-schema.xml",
                            LogFileFolder = "Logs"};
                    }

                    if (!typeof(SteagConfiguration).IsAssignableFrom(section.GetType()))
                        throw new Exception(string.Format("Congif Section Steag.Security is not of type {0}", typeof(SteagConfiguration).FullName));

                    _steageConfiguration = section as SteagConfiguration;
                }
                return _steageConfiguration;
            }
        }
    }
}
