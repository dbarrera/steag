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
using System.Reflection;

namespace Steag.Data
{
    public abstract class DataSession: IDisposable
    {
        private DataContext _dataContext;
        private static XmlMappingSource _xmlMappingSource;

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
        
        private static XmlMappingSource MappingSource
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

        public static void ResetMappingSource()
        {
            _xmlMappingSource = null;
        }

        protected internal virtual DataContext DataContext
        {
            get
            {
                if(Equals(_dataContext, null))
                {                   
                    var connectionStringKey = SteagConfiguration.Default.ConnectionStringKey;
                    
                    var connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey];

                    if(Equals(connectionString, null))
                        throw new Exception(string.Format("Unknown Connection String {0}", connectionStringKey));

                    var providerName = connectionString.ProviderName;
                    var factory = DbProviderFactories.GetFactory(providerName);

                    if(Equals(factory, null))
                        throw new Exception(string.Format("Unknown Provider {0}", providerName));

                    var dbConnection = factory.CreateConnection();
                    dbConnection.ConnectionString = connectionString.ConnectionString;
                    
                    _dataContext = new DataContext(dbConnection, MappingSource);
                }
                return _dataContext;
            }
        }

        protected DataSession(User user)
        {
            CurrentUser = user;
        }

        protected DataSession()
        {
            CurrentUser = User.Default;
        }

        public void SubmitChanges()
        {
            DataContext.SubmitChanges();
        }

        public void Dispose()
        {
            CurrentUser = null;
            _dataContext = null;            
        }
    }
}
