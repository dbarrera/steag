using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Model;
using Steag.Data;
using Steag.Framework.Authentication;

namespace Steag.Business
{
    public class SarfLogic : LogicBase
    {
        #region DataSession
        private SarfDataSession _sarfDataSession;

        protected override IDataSession CurrentDataSession
        {
            get { return DataSession; }
        }

        private SarfDataSession DataSession
        {
            get
            {
                _sarfDataSession = _sarfDataSession ?? new SarfDataSession(CurrentUser, CurrentDataSource);
                return _sarfDataSession;
            }
        }
        #endregion

        #region Constructor
        public SarfLogic(IDataSource dataSource)
            : base(dataSource)
        {
        }

        public SarfLogic(User user, IDataSource dataSource)
            : base(user, dataSource)
        {
        }
        #endregion

        #region Methods
        public SARF GetSarfByID(long id)
        {
            return DataSession.GetByID(id);
        }

        public SARF GetSarfByCode(string sarfCode)
        {
            return DataSession.GetByCode(sarfCode);
        }

        public IEnumerable<SARF> GetAllRecord()
        {
            bool excludeInactive = true;

            return DataSession.GetAll(excludeInactive);
        }

        public void AddSarf(SARF sarf)
        {
            DataSession.AddSarf(sarf);
        }

        public void AddSarfs(IEnumerable<SARF> sarfs)
        {
            if (Equals(sarfs, null))
                throw new ArgumentNullException("SARF");

            DataSession.AddSarfs(sarfs);
        }

        public void DeleteSarf(SARF sarf)
        {
            if (Equals(sarf, null))
                throw new ArgumentNullException("SARF");

            DataSession.DeleteSarf(sarf);
        }
        #endregion
    }
}
