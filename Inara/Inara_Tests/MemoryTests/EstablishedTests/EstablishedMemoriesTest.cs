using System;
using NUnit.Framework;

namespace Inara_Tests.MemoryTests.EstablishedTests
{
    [TestFixture]
    public class EstablishedMemoriesTest
    {
        [Test]
        public void GetsAndSetsName()
        {
            const string NAME = "Some Name";
            string result = "";

            Inara.Memory.Established.IEstablishedMemories testObject;
            testObject = new Inara.Memory.Established.EstablishedMemories();

            testObject.setName(NAME);
            result = testObject.getName();

            Assert.AreEqual(NAME, result, "set name is gotten");
        }
    }
}
