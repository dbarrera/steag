using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Steag.Framework.Model;
using Steag.Framework.Authentication;
namespace Steag.Data
{
    public class EACSDataSession: DataSession
    {
        public EACSDataSession(IDataSource dataSource)
            : base(dataSource)
        { 
        }

        public EACSDataSession(User user, IDataSource dataSource)
            :base(user, dataSource)
        {
        }

        public static EACS NewEACS()
        {
            return new EACS();
        }

        public EACS GetEACSByID(long id)
        {
            return DataContext.EACS.SingleOrDefault(e => e.ID == id);
        }

        public EACS GetEACSBySarfID(long id)
        {
            return DataContext.EACS.SingleOrDefault(e => e.SARFID == id);
        }

        public EACS GetEACSByCode(string code)
        {
            return DataContext.EACS.SingleOrDefault(e => e.EACSCode.Equals(code));
        }

        public IEnumerable<EACS> GetAllEACS()
        {
            return from e in DataContext.EACS select e;
        }

        public IEnumerable<EACS> GetAllEACS(bool isActive)
        {
            return from e in DataContext.EACS select e;
        }

        public void AddEACS(EACS eacs)
        {
            DataContext.EACS.InsertOnSubmit(eacs);
        }

        public void AddEACS(IEnumerable<EACS> eacs)
        {
            DataContext.EACS.InsertAllOnSubmit(eacs);
        }

        public void DeleteEACS(EACS eacs)
        {
            DataContext.EACS.DeleteOnSubmit(eacs);
        }

        public EACSPersons GetEACSPersonByID(long id)
        {
            return DataContext.EACSPersons.SingleOrDefault(e => e.ID == id);
        }

        public IEnumerable<EACSPersons> GetEACSPersons(long eacsID)
        { 
            return from e in DataContext.EACSPersons where e.EACSID == eacsID select e;
        }
    }
}
