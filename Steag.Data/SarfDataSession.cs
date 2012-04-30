using System.Collections.Generic;
using System.Linq;
using Steag.Framework.Authentication;
using Steag.Framework.Model;
using System;

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

        public SARF GetByID(Int64 id)
        {
            return DataContext.SARF.SingleOrDefault(u => u.ID == id);
        }

        public SARF GetByCode(string sarfCode)
        {
            return DataContext.SARF.SingleOrDefault(u => u.SARFCode.Equals(sarfCode));
        }

        public IEnumerable<SARF> GetAll(bool isActive)
        {
            return from u in DataContext.SARF where u.IsActive == isActive select u;
        }

        public void AddSarf(SARF sarf)
        {
            DataContext.SARF.InsertOnSubmit(sarf);
        }

        public void AddSarfs(IEnumerable<SARF> sarfs)
        {
            DataContext.SARF.InsertAllOnSubmit(sarfs);
        }

        public void DeleteSarf(SARF sarf)
        {
            DataContext.SARF.DeleteOnSubmit(sarf);
        }
    }
}