using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Security;
using System.Web.SessionState;
using Steag.Framework.Diagnostics;
using Steag.Framework.Logging;
using Steag.Business;
using Steag.Data;
using Steag.Web.Presentation.Security.Audit;
using Steag.Web.Presentation.Security.Authentication;
using Steag.Business.Handler;

namespace Steag.Web.Presentation.Security
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

            //Setup TraceUtil Listener
            var listener = new LogWriterTraceListener();
            TraceUtil.AddListener(listener);

            //Set System Access Handler
            var systemAccessHandler = new SteagSystemAccessHandler();
            SystemAccessHandler.SetCurrentSystemAccessHandler(systemAccessHandler);

            //Set Model Entity Auditor
            var auditor = new Audit.Auditor();
            DataSession.SetAuditor(auditor);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
