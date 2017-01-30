using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBuildingClass;

namespace TheBuildingClass.Tests
{
    [TestClass]
    public class BuildingTests
    {
        [TestMethod]
        public void BuildingToStringNoParamConstructor()
        {
            Building building = new Building();
            Assert.AreEqual("Address: ", building.ToString());
        }

        [TestMethod]
        public void BuildingToStringAdressConstructor()
        {
            Building building = new Building("London");
            Assert.AreEqual("Address: London", building.ToString());
        }
    }
}
