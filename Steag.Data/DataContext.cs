using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Model;
using Steag.Framework.Authentication;

namespace Steag.Data
{
    public partial class DataContext: System.Data.Linq.DataContext
    {

        internal User CurrentUser { get; set; }

        public override void SubmitChanges(System.Data.Linq.ConflictMode failureMode)
        {
            var changeSet = GetChangeSet();
            foreach (var entity in changeSet.Inserts)
            {
                if (typeof(IAuditable).IsAssignableFrom(entity.GetType()))
                    DataSession.Audit(entity as IAuditable, CurrentUser);
                
            }

            foreach (var entity in changeSet.Updates)
            {
                if (typeof(IAuditable).IsAssignableFrom(entity.GetType()))
                    DataSession.Audit(entity as IAuditable, CurrentUser);
            }
            base.SubmitChanges(failureMode);
        }
    }
}
