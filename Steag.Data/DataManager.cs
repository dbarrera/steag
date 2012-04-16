using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.Common;
using Steag.Framework.Configuration;

namespace Steag.Data
{
    public class DataManager
    {
        public static IDataSource CreateDefaultDataSource()
        {
            var connectionStringKey = SteagConfiguration.Default.ConnectionStringKey;

            var connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey];

            if (Equals(connectionString, null))
                throw new Exception(string.Format("Unknown Connection String {0}", connectionStringKey));

            var providerName = connectionString.ProviderName;
            var factory = DbProviderFactories.GetFactory(providerName);

            if (Equals(factory, null))
                throw new Exception(string.Format("Unknown Provider {0}", providerName));

            var dbConnection = factory.CreateConnection();
            dbConnection.ConnectionString = connectionString.ConnectionString;

            var contextMappingSource = DataCachingManager.Current.MappingSource;

            var mappingSource = new Mapping.MappingSource(string.Empty);
            mappingSource.DataContextMappingSource = contextMappingSource;

            if (Equals(mappingSource, null))
                throw new Exception("Xml Mapping Source is not specified");

            var context = new DataContext(dbConnection, contextMappingSource);
            return new DataSource(dbConnection, context, mappingSource);
        }
    }
}
