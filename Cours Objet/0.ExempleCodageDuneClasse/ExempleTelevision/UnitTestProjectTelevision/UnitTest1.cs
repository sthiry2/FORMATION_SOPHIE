using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectTelevision
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            NameSpaceTelevision.Television t = new NameSpaceTelevision.Television();
            Assert.(t, new NameSpaceTelevision.Television());
        }
    }
}
