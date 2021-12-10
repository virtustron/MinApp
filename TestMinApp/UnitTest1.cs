using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using MinApp;

namespace TestMinApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMinSuccesAverage()
        {
            int min;

            min = Program.Min(3, 2, 5);

            Assert.AreEqual(2, min);
        }

        [TestMethod]
        public void TestMinSuccesBigPositives()
        {
            int min;

            min = Program.Min(32457, 2784, 5687);

            Assert.AreEqual(2784, min);
        }

        [TestMethod]
        public void TestMinSuccesBigNegatives()
        {
            int min;

            min = Program.Min(-32457, -2784, -5687);

            Assert.AreEqual(-32457, min);
        }

        [TestMethod]
        public void TestMinSuccesPositivesAndNegatives()
        {
            int min;

            min = Program.Min(+32457, -2784, +5687);

            Assert.AreEqual(-2784, min);
        }
    }
}
