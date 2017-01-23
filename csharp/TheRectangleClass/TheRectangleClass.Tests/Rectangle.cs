using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheRectangleClass.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Perimeter()
        {
            Rectangle rect = new Rectangle(3, 4);
            Assert.AreEqual(14, rect.Perimeter());
        }
        [TestMethod]
        public void Area()
        {
            Rectangle rect = new Rectangle(3, 4);
            Assert.AreEqual(12, rect.Area());
        }
        [TestMethod]
        public void IsSquareTrue()
        {
            Rectangle rect = new Rectangle(3, 3);
            Assert.AreEqual(true, rect.IsSquare());
        }
        [TestMethod]
        public void IsSquareFalse()
        {
            Rectangle rect = new Rectangle(3, 4);
            Assert.AreEqual(false, rect.IsSquare());
        }
        [TestMethod]
        public void DisplayRectangleData()
        {
            Rectangle rect = new Rectangle(4, 5);
            Assert.AreEqual("Length: 4\nWidth: 5\nPerimeter: 18\nArea: 20\nIs a square: False", rect.DisplayRectangleData());
        }
    }
}
