using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Common;
using System.Data.Linq.Mapping;
using System.Text;
using System.IO;
using System.Configuration;
using Steag.Framework.Configuration;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public abstract class DataSession
    {
        private DataContext _dataContext;

        public virtual User CurrentUser { get; protected set; }

        private Framework.Event.EventDispatcher EventDispatcher
        {
            get { return Framework.Event.EventDispatcher.Current; }
        }
        
        protected void RaiseEvent(string eventName, EventArgs e)
        {
            EventDispatcher.RaiseEvent(eventName, this, e);
        }

        protected void RaiseEvent(string eventName, object sender, EventArgs e)
        {
            EventDispatcher.RaiseEvent(eventName, sender, e);    
        }

        protected virtual System.Data.Linq.DataContext DataContext
        {
            get
            {
                if(Equals(_dataContext, null))
                {
                    var section = System.Configuration.ConfigurationManager.GetSection("Steag.Security");

                    if(Equals(section, null))
                        throw new Exception("Config Section Steag.Security is not implemented");

                    if(!typeof(SteagConfiguration).IsAssignableFrom(section.GetType()))
                        throw new Exception(string.Format("Congif Section Steag.Security is not of type {0}", typeof(SteagConfiguration).FullName));

                    var configSection = section as SteagConfiguration;
                    
                    var connectionStringKey = configSection.ConnectionStringKey;
                    
                    var connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey];

                    if(Equals(connectionString, null))
                        throw new Exception(string.Format("Unknown Connection String {0}", connectionStringKey));

                    var mappingSourceFile = configSection.MappingSource;

                    if(!File.Exists(mappingSourceFile))
                        throw new FileNotFoundException(mappingSourceFile);

                    var mappingSource = XmlMappingSource.FromStream(File.Open(mappingSourceFile, FileMode.Open));

                    var providerName = connectionString.ProviderName;

                    var factory = DbProviderFactories.GetFactory(providerName);

                    if(Equals(factory, null))
                        throw new Exception(string.Format("Unknown Provider {0}", providerName));

                    var dbConnection = factory.CreateConnection();
                    dbConnection.ConnectionString = connectionString.ConnectionString;

                    _dataContext = new DataContext(dbConnection, mappingSource);
                }
                return _dataContext;
            }
        }

        protected DataSession(User user)
        {
            CurrentUser = user;
        }
    }
}
