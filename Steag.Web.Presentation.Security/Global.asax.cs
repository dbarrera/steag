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

namespace Steag.Web.Presentation.Security
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            var listener = new LogWriterTraceListener();
            TraceUtil.AddListener(listener);

            var systemAccessHandler = new Authentication.SteagSystemAccessHandler();
            Steag.Business.Handler.SystemAccessHandler.SetCurrentSystemAccessHandler(systemAccessHandler);
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
