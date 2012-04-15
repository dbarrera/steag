using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using Steag.Framework.Configuration;
using System.Configuration;
using System.Data.Common;
using System.Data.Linq;
using System.Data;
using System.IO;

namespace Steag.Data
{
    public class DataSource: IDataSource, IDisposable
    {
        private System.Data.Linq.DataContext _dataContext;        

        private IDbTransaction Transaction { get; set; }

        public Mapping.IMappingSource MappingSource { get; set; }

        #region Connection
        public IDbConnection Connection { get; set; }
        #endregion

        #region Constructor
        public DataSource(IDbConnection connection, Mapping.IMappingSource mappingSource)
        {
            Connection = connection;
            MappingSource = mappingSource;
        }

        internal DataSource(IDbConnection connection, DataContext dataContext, Mapping.MappingSource mappingSource)
        {
            Connection = connection;
            MappingSource = mappingSource;
            _dataContext = dataContext;
        }
        #endregion

        #region DataContext
        internal System.Data.Linq.DataContext DataContext
        {
            get
            {
                if (Equals(_dataContext, null))
                {
                    var mappingSourceFile = MappingSource.MappingSourceFile;

                    if (!File.Exists(mappingSourceFile))
                        throw new FileNotFoundException(mappingSourceFile);

                    var stream = new FileStream(mappingSourceFile, FileMode.Open);
                    var xmlMappingSource = XmlMappingSource.FromStream(stream);
                    _dataContext = _dataContext ?? new System.Data.Linq.DataContext(Connection, xmlMappingSource);
                }                
                return _dataContext;
            }
        }
        #endregion

        #region Transaction
        public void BeginTransaction()
        {
            if (!Equals(Connection.State, ConnectionState.Open))
                DataContext.Connection.Open();

            DataContext.Transaction = DataContext.Connection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (Equals(DataContext.Transaction, null))
                throw new Exception("No Transaction Initiated");

            DataContext.Transaction.Commit();
        }

        public void RollbackTransaction()
        {
            if (Equals(DataContext.Transaction, null))
                throw new Exception("No Transaction Initiated");

            DataContext.Transaction.Rollback();
        }
        #endregion

        #region Changes
        public void SubmitChanges()
        {            
            DataContext.SubmitChanges();
        }

        public void RollBackChanges()
        {
            DataContext.Refresh(RefreshMode.OverwriteCurrentValues);
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {            
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!Equals(_dataContext, null))
                {
                    _dataContext.Dispose();
                    _dataContext = null;
                }
            }
        }
        #endregion
    }
}
