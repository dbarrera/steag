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
        public SarfLogic(User user, IDataSource dataSource)
            : base(user, dataSource)
        {
        }

        public SarfLogic(IDataSource dataSource)
            : base(dataSource)
        {
        }
        #endregion

        #region Methods
        public SARF GetSarfByID(long id)
        {
            return DataSession.GetSarfByID(id);
        }
        #endregion
    }
}
