using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Model;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public class SarfDataSession : DataSession
    {
        public SarfDataSession(IDataSource dataSource)
            : base(dataSource)
        {
        }

        public SarfDataSession(User user, IDataSource dataSource)
            : base(user, dataSource)
        {
        }

        public SARF GetSarfByID(long id)
        {
            return DataContext.SARF.SingleOrDefault(u => u.ID == id);
        }
    }
}