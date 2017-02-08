using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheVehicleAbstractClass.Vehicles;

namespace TheVehicleAbstractClass.Unit.Tests
{
    [TestClass]
    public class TruckTests
    {
        [TestMethod]
        public void Truck_WithParams_ShouldCreateATruck()
        {
            Truck t = new Truck(1999, 10000);

            Assert.AreEqual(t.Year, 1999);
            Assert.AreEqual(t.Price, 10000);
            Assert.IsNotNull(t.RegistrationNumber);
        }

        [TestMethod]
        public void Start_ShouldStartTheTruck()
        {
            Truck t = new Truck(1999, 10000);

            Assert.AreEqual(t.Start(), "The truck is starting...");
        }

        [TestMethod]
        public void Accelerate_ShouldAccelerateTruck()
        {
            Truck t = new Truck(1999, 10000);

            Assert.AreEqual(t.Accelerate(), "The truck is accelerating...");
        }

        [TestMethod]
        public void ToString_ShouldDisplayTruckData()
        {
            Truck t = new Truck(1999, 10000);

            Assert.AreEqual(t.ToString(), "Truck: Registration number: " + t.RegistrationNumber + ", Year: 1999, Price: 10000");
        }
    }
}
