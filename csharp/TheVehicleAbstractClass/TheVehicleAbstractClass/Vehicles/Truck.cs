using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVehicleAbstractClass.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(int year, double price) : base(year, price) { }

        public override string Start()
        {
            return "The truck is starting...";
        }

        public override string Accelerate()
        {
            return "The truck is accelerating...";
        }

        public override string ToString()
        {
            return "Truck: " + base.ToString();
        }
    }
}
