using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThePointClass.Tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void DistanceAtOrigin()
        {
            Point point = new Point(0, 0);
            Assert.AreEqual(0, point.Distance());
        }

        [TestMethod]
        public void DistanceAtPositivePoint()
        {
            Point point = new Point(1, 2);
            Assert.AreEqual(2.23, point.Distance(), 0.01);
        }

        [TestMethod]
        public void DistanceAtNegativePoint()
        {
            Point point = new Point(-3, -4);
            Assert.AreEqual(5, point.Distance(), 0.01);
        }
    }
}
