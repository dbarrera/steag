using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Model;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public class AutoNumberingDataSession: DataSession
    {
        public AutoNumberingDataSession(IDataSource dataSource)
            : base(dataSource)
        { 
        }

        public AutoNumberingDataSession(User user, IDataSource dataSource)
            :base(user, dataSource)
        {
        }

        public AutoNumbering GetAutoNumbering(string transactionCode)
        {
            return DataContext.AutoNumbering.SingleOrDefault(x => x.TransactionCode == transactionCode);
        }
    }
}
