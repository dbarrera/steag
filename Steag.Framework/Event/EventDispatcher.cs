using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Event
{
    public class EventDispatcher
    {
        private List<IEventListener> _listeners;
        private static EventDispatcher _eventDispatcher;

        private List<IEventListener> Listeners
        {
            get
            {
                _listeners = _listeners ?? new List<IEventListener>();
                return _listeners;
            }
        }

        public void RaiseEvent(string eventName, object sender, EventArgs e)
        {
            Listeners.ForEach(l => l.Invoke(eventName, sender, e));
        }

        public void AddEventListener(IEventListener listener)
        {
            if (Equals(listener, null))
                throw new ArgumentNullException("listener");

            Listeners.Add(listener);
        }

        public static EventDispatcher Current
        {
            get { _eventDispatcher = _eventDispatcher ?? new EventDispatcher();
                return _eventDispatcher;
            }
        }
    }
}
