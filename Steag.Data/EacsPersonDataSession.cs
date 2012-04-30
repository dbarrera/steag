using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Steag.Framework.Model;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public class EacsPersonDataSession : DataSession
    {
        public EacsPersonDataSession(IDataSource dataSource)
            : base(dataSource)
        {
        }

        public EacsPersonDataSession(User user, IDataSource dataSource)
            : base(user, dataSource)
        {
        }

        public EACSPersons GetByID(Int64 id)
        {
            return DataContext.EACSPersons.SingleOrDefault(e => e.ID == id);
        }

        public EACSPersons GetByEacsID(Int64 id)
        {
            return DataContext.EACSPersons.SingleOrDefault(e => e.ID == id);
        }

        public EACSPersons GetByPersonID(Int64 id)
        {
            return DataContext.EACSPersons.SingleOrDefault(e => e.ID == id);
        }

        public IEnumerable<EACSPersons> GetAll()
        {
            return from e in DataContext.EACSPersons select e;
        }

        public IEnumerable<EACSPersons> GetAll(bool isActive)
        {
            return from e in DataContext.EACSPersons where e.IsActive == isActive select e;
        }

        public void AddEacsPersons(EACSPersons eacsPerson)
        {
            DataContext.EACSPersons.InsertOnSubmit(eacsPerson);
        }

        public void AddEacsPersons(IEnumerable<EACSPersons> eacsPersons)
        {
            DataContext.EACSPersons.InsertAllOnSubmit(eacsPersons);
        }

        public void Delete(EACSPersons eacsPerson)
        {
            DataContext.EACSPersons.DeleteOnSubmit(eacsPerson);
        }
    }
}
