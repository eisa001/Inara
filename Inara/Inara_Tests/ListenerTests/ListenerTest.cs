using System;
using NUnit.Framework;
using Inara;

namespace Listener.Tests
{
    [TestFixture]
    public class ListenerTest
    {
        [Test]
        public void ShouldListenToInput()
        {
            const string INPUT = "Some Input";
            var result = "";

            var testObject = new Inara.Listener.Listener();
            result = testObject.listen(INPUT);

            Assert.AreEqual(INPUT, result, "Listens to input");
        }
    }
}
