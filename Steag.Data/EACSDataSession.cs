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

        public EACS GetEACS(long id)
        {
            return DataContext.EACS.FirstOrDefault(e => e.ID == id);
        }
    }
}
