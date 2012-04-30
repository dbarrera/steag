using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Model;
using Steag.Framework.Authentication;
using Steag.Data;

namespace Steag.Business
{
    public class SARFLogic: LogicBase
    {
        #region DataSession
        private SARFDataSession _sarfDataSession;

        protected override IDataSession CurrentDataSession
        {
            get { return DataSession; }
        }

        private SARFDataSession DataSession
        {
            get
            {
                _sarfDataSession = _sarfDataSession ?? new SARFDataSession(CurrentUser, CurrentDataSource);
                return _sarfDataSession;
            }
        }
        #endregion

        #region Constructor
        public SARFLogic(IDataSource dataSource)
            : base(dataSource)
        {
        }

        public SARFLogic(User user, IDataSource dataSource)
            : base(user, dataSource)
        {
        }
        #endregion

        #region Methods
        public static SARF NewSARF()
        {
            return new SARF();
        }

        public SARF GetSARFByID(long id)
        {
            return DataSession.GetSARFByID(id);
        }

        public SARF GetSARFByCode(string sarfCode)
        {
            return DataSession.GetSARFByCode(sarfCode);
        }

        public IEnumerable<SARF> GetAllRecord()
        {
            bool excludeInactive = true;

            return DataSession.GetAllSARFs(excludeInactive);
        }

        public void AddSARF(SARF sarf)
        {
            if (Equals(sarf, null))
                throw new ArgumentNullException("sarf");

            sarf.SARFCode = GenerateDocumentCode("SARF");
            DataSession.AddSARF(sarf);
        }

        public void AddSARFs(IEnumerable<SARF> sarfs)
        {
            if (Equals(sarfs, null))
                throw new ArgumentNullException("SARF");

            DataSession.AddSARFs(sarfs);
        }

        public void DeleteSARF(SARF sarf)
        {
            if (Equals(sarf, null))
                throw new ArgumentNullException("SARF");

            DataSession.DeleteSARF(sarf);
        }

        public void ApproveSARF(SARF sarf)
        {
            sarf.Status = "Approved";
        }

        public void RejectSARF(SARF sarf)
        {
            sarf.Status = "Denied";
        }

        public void CloseSARF(SARF sarf)
        {            
            sarf.Status = "Closed";
        }

        public IEnumerable<SARF> GetApprovedSARFsByVisitDate(DateTime dateOfVisit)
        {
            return DataSession.GetApprovedSARFsByVisitDate(dateOfVisit);
        }

        public IEnumerable<SARF> GetSARFsByVisitDate(DateTime dateofVisit, string status)
        {
            return DataSession.GetSARFsByVisitDate(dateofVisit, status);
        }

        /// <summary>
        /// Create an EACS out of a SARF entity
        /// </summary>
        /// <param name="sarf"></param>
        /// <returns></returns>
        public EACS CreateEACSFromSARF(SARF sarf)
        {
            return default(EACS);
        }
        #endregion
    }
}
