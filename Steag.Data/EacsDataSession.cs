using System.Collections.Generic;
using System.Linq;
using Steag.Framework.Authentication;
using Steag.Framework.Model;

namespace Steag.Data
{
    public class EacsDataSession: DataSession
    {
        public EacsDataSession(IDataSource datasource)
            : base(datasource)
        {
        }

        public EacsDataSession(User user, IDataSource dataSource)
            : base(user, dataSource)
        {
        }

        public EACS GetEacsByID(long id)
        {
            return DataContext.EACS.SingleOrDefault(e => e.ID == id);
        }

        public EACS GetEacsBySarfID(long id)
        {
            return DataContext.EACS.SingleOrDefault(e => e.SARFID == id);
        }

        public EACS GetEacsByCode(string code)
        {
            return DataContext.EACS.SingleOrDefault(e => e.EACSCode.Equals(code));
        }

        public IEnumerable<EACS> GetAllEacs()
        {
            return from e in DataContext.EACS select e;
        }

        public IEnumerable<EACS> GetAllEacs(bool isActive)
        {
            return from e in DataContext.EACS select e;
        }

        public void AddEacs(EACS eacs)
        {
            DataContext.EACS.InsertOnSubmit(eacs);
        }

        public void AddEacs(IEnumerable<EACS> eacs)
        {
            DataContext.EACS.InsertAllOnSubmit(eacs);
        }

        public void DeleteEacs(EACS eacs)
        {
            DataContext.EACS.DeleteOnSubmit(eacs);
        }
    }
}
