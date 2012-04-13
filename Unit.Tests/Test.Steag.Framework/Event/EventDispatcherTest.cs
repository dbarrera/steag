using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Event;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Steag.Framework.Event
{
    [TestClass]
    public class EventDispatcherTest
    {
        [TestMethod]
        public void EventDispatcherInstanceTest()
        {
            var dispatcher = EventDispatcher.Current;
            Assert.IsTrue(!Equals(dispatcher, null) && typeof(EventDispatcher).IsAssignableFrom(dispatcher.GetType()));
        }

        [TestMethod]
        public void AddListener()
        {
            var dispatcher = EventDispatcher.Current;
            var listener = new Mock<IEventListener>();

            dispatcher.AddEventListener(listener.Object);
            dispatcher.RaiseEvent("testEvent", this, EventArgs.Empty);
            listener.Verify(l => l.Invoke("testEvent", this, EventArgs.Empty), Times.Once());
        }

        [TestMethod]
        public void AddListenerNull()
        {
            var dispatcher = EventDispatcher.Current;
            try
            {
                dispatcher.AddEventListener(null);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentNullException);
            }
            
        }
    }
}
