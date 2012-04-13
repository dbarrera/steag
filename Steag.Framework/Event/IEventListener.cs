using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Event
{
    public interface IEventListener
    {
        void Invoke(string eventName, object sender, EventArgs e);
    }
}
