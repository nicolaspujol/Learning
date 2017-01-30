using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBuildingClass;

namespace TheBuildingClass.Tests
{
    [TestClass]
    public class HouseTests
    {
        [TestMethod]
        public void HouseToStringNoParamConstructor()
        {
            House house = new House();
            Assert.AreEqual("Address: , Rooms: 0", house.ToString());
        }

        [TestMethod]
        public void HouseToStringAdressConstructor()
        {
            House house = new House("London", 2);
            Assert.AreEqual("Address: London, Rooms: 2", house.ToString());
        }
    }
}
