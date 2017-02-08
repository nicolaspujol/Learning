using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheVehicleAbstractClass.Vehicles;

namespace TheVehicleAbstractClass.Unit.Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Car_WithParams_ShouldCreateACar()
        {
            Car c = new Car(1999, 10000);

            Assert.AreEqual(c.Year, 1999);
            Assert.AreEqual(c.Price, 10000);
            Assert.IsNotNull(c.RegistrationNumber);
        }

        [TestMethod]
        public void Start_ShouldStartTheCar()
        {
            Car c = new Car(1999, 10000);

            Assert.AreEqual(c.Start(), "The car is starting...");
        }

        [TestMethod]
        public void Accelerate_ShouldAccelerateCar()
        {
            Car c = new Car(1999, 10000);

            Assert.AreEqual(c.Accelerate(), "The car is accelerating...");
        }

        [TestMethod]
        public void ToString_ShouldDisplayCarData()
        {
            Car c = new Car(1999, 10000);

            Assert.AreEqual(c.ToString(), "Car: Registration number: " + c.RegistrationNumber + ", Year: 1999, Price: 10000");
        }
    }
}
