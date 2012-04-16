using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Steag.Framework.Configuration;
using System.Data.Linq.Mapping;

namespace Steag.Data
{
    internal class DataCachingManager: IDataCachingManager
    {
        private XmlMappingSource _xmlMappingSource;
        private static IDataCachingManager _dataCachingManager;

        public XmlMappingSource MappingSource
        {             
            get
            { 
                if(Equals(_xmlMappingSource, null))
                {
                    var mappingSourceFile = SteagConfiguration.Default.MappingSource;

                    if (!File.Exists(mappingSourceFile))
                        throw new FileNotFoundException(mappingSourceFile);

                    using (var stream = new FileStream(mappingSourceFile, FileMode.Open))
                    {
                        _xmlMappingSource = XmlMappingSource.FromStream(stream);
                    }
                }
                return _xmlMappingSource;
            }
        }

        public void ResetMappingSource()
        {
            _xmlMappingSource = null;
        }

        private DataCachingManager()
        { 
        
        }

        public static IDataCachingManager Current
        {
            get
            {

                _dataCachingManager = _dataCachingManager ?? new DataCachingManager();
                return _dataCachingManager;               
            }         
        }

        public static void SetDataCachingManager(IDataCachingManager manager)
        {
            if (Equals(manager, null))
                throw new ArgumentNullException("manager");
            _dataCachingManager = manager;
        }
    }
}
