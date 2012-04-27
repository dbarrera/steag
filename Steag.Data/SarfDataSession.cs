using System.Collections.Generic;
using System.Linq;
using Steag.Framework.Authentication;
using Steag.Framework.Model;

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

        public SARF GetSarfByCode(string sarfCode)
        {
            return DataContext.SARF.SingleOrDefault(u => u.SARFCode.Equals(sarfCode));
        }

        public IEnumerable<SARF> GetAllSarf(bool isActive)
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