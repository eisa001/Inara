using System;
using NUnit.Framework;
using Inara;

namespace Vocaliser.Tests
{
    [TestFixture]
    public class VocaliserTest
    {
        [Test]
        public void ShouldGreetWhenGreeted()
        {
            const string GREETING = "Hello World!";
            string result = "";

            Inara.Vocaliser.IVocaliser testObject = new Inara.Vocaliser.Vocaliser();
            result = testObject.Speaker(GREETING);

            Assert.AreEqual(GREETING, result, "accepts and parrots greetings");
        }
    }
}
