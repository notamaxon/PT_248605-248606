using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_0;

namespace Task_0_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Human test = new Human("Eugene");
            Assert.AreEqual(test.greet("Maksym"),"Eugene greets Maksym");
        }
    }
}
