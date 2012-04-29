using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Model;
using Steag.Framework.Authentication;
using Steag.Data;

namespace Steag.Business
{
    public class AutoNumberingLogic: LogicBase
    {
        private AutoNumberingDataSession _autoNumberingDataSession;

        protected override IDataSession CurrentDataSession
        {
            get 
            {                
                return DataSession;
            }
        }

        private AutoNumberingDataSession DataSession
        {
            get
            {
                _autoNumberingDataSession = _autoNumberingDataSession ?? new AutoNumberingDataSession(CurrentUser, CurrentDataSource);
                return _autoNumberingDataSession;
            }
        }

        public AutoNumberingLogic(User user, IDataSource dataSource)
            :base(user, dataSource)
        {
        }

        public AutoNumberingLogic(IDataSource dataSource)
            :base(dataSource)
        {             
        }

        public AutoNumbering GetAutoNumbering(string transactionCode)
        {
            return DataSession.GetAutoNumbering(transactionCode);
        }

        public string GenerateDocumentCode(string transactionCode)
        {
            if (Equals(transactionCode, null))
                throw new ArgumentNullException("transactionCode");

            var autoNumbering = GetAutoNumbering(transactionCode);

            if (Equals(autoNumbering, null))
                return string.Empty;

            var codeFormat = autoNumbering.Format;

            if (string.IsNullOrEmpty(codeFormat))
                codeFormat = "{:prefix}{:counter}{:suffix}";

            autoNumbering.Counter++;           
            
            codeFormat = codeFormat.Replace(":prefix","0");
            codeFormat = codeFormat.Replace(":suffix", "1");
            codeFormat = codeFormat.Replace(":counter", "2");
            
            var documentCode = string.Format(codeFormat, autoNumbering.Prefix ?? string.Empty,
                autoNumbering.Suffix ?? string.Empty, autoNumbering.Counter);
            
            return documentCode;
        }
    }
}
