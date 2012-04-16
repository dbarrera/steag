﻿using System;
using System.Collections.Generic;
using System.Linq;
using Steag.Web.Base;
using Steag.Data;

namespace Steag.Web.Presentation.Security.Base
{
    public abstract class SecurePage: Page
    {
        private bool _requiresAuthentication = true;

        public override string Description
        {
            get { return GetType().FullName; }
        }

        protected override bool RequiresAuthentication
        {
            get 
            { 
                return _requiresAuthentication; 
            }
            set 
            { 
                _requiresAuthentication = value; 
            }
        }

        protected virtual IDataSource NewDataSource()
        {
            return DataManager.CreateDefaultDataSource();
        }
        
    }
}