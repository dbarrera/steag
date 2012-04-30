using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Data;
using Steag.Framework.Authentication;

namespace Steag.Business
{
    public abstract class LogicBase: ILogic, IDisposable
    {

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

        #region CurrentDataSession
        protected abstract IDataSession CurrentDataSession { get; }
        #endregion

        #region CurrentDataSource
        protected virtual IDataSource CurrentDataSource { get; set; }
        #endregion

        #region Constructor
        protected LogicBase(User user, IDataSource dataSource)
        {
            CurrentUser = user;
            CurrentDataSource = dataSource;
        }

        protected LogicBase(IDataSource dataSource)
            :this(User.Default, dataSource)
        {             
        }
        #endregion

        #region Methods
        protected virtual bool Validate(object entity)
        {
            return true;
        }

        public virtual string GenerateDocumentCode(string transactionCode)
        {
            if (Equals(transactionCode, null))
                throw new ArgumentNullException("transactionCode");

            var autoNumberingLogic = new AutoNumberingLogic(CurrentUser, CurrentDataSource);
            var documentCode = autoNumberingLogic.GenerateDocumentCode(transactionCode);
            if (Equals(CurrentDataSource, null))
                throw new Exception("CurrentDataSource is not set to an instance");
            CurrentDataSource.SubmitChanges();
            return documentCode;
        }

        public virtual void SubmitChanges()
        {
            if (Equals(CurrentDataSource, null))
                throw new Exception("CurrentDataSource is not set to an instance");
            CurrentDataSource.SubmitChanges();
        }

        public virtual void RollBackChanges()
        {
            if (Equals(CurrentDataSource, null))
                throw new Exception("CurrentDataSource is not set to an instance");
            CurrentDataSource.RollBackChanges();
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
                if(!Equals(CurrentDataSession, null))
                    CurrentDataSession.Dispose();
            }
        }
        #endregion

    }
}
