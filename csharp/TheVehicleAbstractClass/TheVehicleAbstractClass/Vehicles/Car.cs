using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVehicleAbstractClass.Vehicles
{
    public class Car : Vehicle
    {
        public Car(int year, double price) : base(year, price) { }

        public override string Start()
        {
            return "The car is starting...";
        }

        public override string Accelerate()
        {
            return "The car is accelerating...";
        }

        public override string ToString()
        {
            return "Car: " + base.ToString();
        }
    }
}
