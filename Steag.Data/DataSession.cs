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
    public abstract class DataSession: IDataSession, IDisposable
    {

        #region DataSource
        protected virtual IDataSource DataSource { get; set; }

        internal DataSource CurrentDataSource
        {
            get
            { 
                if(!DataSource.GetType().IsAssignableFrom(typeof(DataSource)))
                    throw new Exception("");
                return DataSource as DataSource;
            }
        }
        #endregion

        #region CurrentUser
        public virtual User CurrentUser { get; protected set; }
        #endregion

        #region EventHandling
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
        #endregion

        #region CurrentDataContext
        protected virtual System.Data.Linq.DataContext CurrentDataContext
        {
            get
            {
                if(Equals(CurrentDataSource, null))
                    throw new Exception("CurrentDataSource is not initialized");
                return CurrentDataSource.DataContext;
            }
        }
        #endregion

        #region DataContext
        protected internal virtual DataContext DataContext
        {
            get
            {
                if (typeof(DataContext).IsAssignableFrom(CurrentDataSource.DataContext.GetType()))
                    return CurrentDataSource.DataContext as DataContext;
                throw new Exception("This DataSession's CurrentDataSource is not compatible source.");
            }
        }
        #endregion

        #region Constructor
        protected DataSession(User user, IDataSource dataSource)
        {
            DataSource = dataSource;
            CurrentUser = user;
        }        

         protected DataSession(IDataSource dataSource)
            : this(User.Default, dataSource)
        { 
        }
        #endregion

        #region Dispose
         public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);                 
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!Equals(CurrentUser, null))
                {
                    CurrentUser.Dispose();
                    CurrentUser = null;
                }                
            }
        }
        #endregion
    }
}
