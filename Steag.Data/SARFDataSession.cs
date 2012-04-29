using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;
using Steag.Framework.Model;
using Steag.Data;

namespace Steag.Data
{
    public class SARFDataSession: DataSession
    {
        public SARFDataSession(IDataSource dataSource)
            : base(dataSource)
        {
        }

        public SARFDataSession(User user, IDataSource dataSource)
            : base(user, dataSource)
        {
        }

        public SARF GetSARFByID(Int64 id)
        {
            return DataContext.SARF.SingleOrDefault(u => u.ID == id);
        }

        public SARF GetSARFByCode(string sarfCode)
        {
            return DataContext.SARF.SingleOrDefault(u => u.SARFCode.Equals(sarfCode));
        }

        public IEnumerable<SARF> GetAllSARFs(bool isActive)
        {
            return from u in DataContext.SARF where u.IsActive == isActive select u;
        }

        public void AddSARF(SARF sarf)
        {
            DataContext.SARF.InsertOnSubmit(sarf);
        }

        public void AddSARFs(IEnumerable<SARF> sarfs)
        {
            DataContext.SARF.InsertAllOnSubmit(sarfs);
        }

        public void DeleteSARF(SARF sarf)
        {
            DataContext.SARF.DeleteOnSubmit(sarf);
        }        
    }
}
