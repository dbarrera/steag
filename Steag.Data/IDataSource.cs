using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Steag.Data
{
    public interface IDataSource: IDisposable
    {        
        void SubmitChanges();
        void RollBackChanges();
                
        IDbConnection Connection { get; set;  }
        Mapping.IMappingSource MappingSource { get; set; }

        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}
