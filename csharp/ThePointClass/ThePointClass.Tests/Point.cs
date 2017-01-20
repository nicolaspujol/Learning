using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThePointClass.Tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void Distance()
        {
            Point point = new Point(0, 0);
            Assert.AreEqual(0, point.Distance());

            Point point2 = new Point(1, 2);
            Assert.AreEqual(2.23, point2.Distance(), 0.01);
        }
    }
}
