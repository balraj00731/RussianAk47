using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RussianAk47;

namespace AK47_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        Russianclass obj_Russian = new Russianclass();
        [TestMethod]
        public void TestMethod1()
        {
            string notification = obj_Russian.fire(1, out int freeshoots);
            Assert.AreEqual(notification, "You losse");
        }

        [TestMethod]
        public void TestMethod2()
        {
            string notification = obj_Russian.fire(5, out int freeshoots);
            Assert.AreNotEqual(notification, "You losse");
        }
    }
}
