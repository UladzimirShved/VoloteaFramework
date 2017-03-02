using System;
using NUnit.Framework;

namespace VoloteaFramework
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.False("Vova" == "Lova");
        }
    }
}
