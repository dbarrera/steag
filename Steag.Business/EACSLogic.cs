using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Authentication;
using Steag.Framework.Security;
using Steag.Framework.Model;
using Steag.Data;
namespace Steag.Business
{
    public class EACSLogic: LogicBase
    {
        #region DataSession
        private EACSDataSession _eacsDataSession;

        protected override IDataSession CurrentDataSession
        {
            get { return DataSession; }
        }

        private EACSDataSession DataSession
        {
            get
            {
                _eacsDataSession = _eacsDataSession ?? new EACSDataSession(CurrentUser, CurrentDataSource);
                return _eacsDataSession;
            }
        }
        #endregion

        #region Constructor
        public EACSLogic(User user, IDataSource dataSource)
            :base(user, dataSource)
        {
        }

        public EACSLogic(IDataSource dataSource)
            :base(dataSource)
        {             
        }
        #endregion

        public EACS GetEACS(long id)
        {            
            return DataSession.GetEACSByID(id);
        }

        protected virtual string GenerateEACSCode()
        {
            return GenerateDocumentCode("EACS");
        }

        public virtual void SaveEACS(EACS eacs)
        {
            eacs.EACSCode = GenerateEACSCode();
            CurrentDataSource.SubmitChanges();
        }
    }
}
