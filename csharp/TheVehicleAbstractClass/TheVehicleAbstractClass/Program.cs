using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheVehicleAbstractClass.Vehicles;

namespace TheVehicleAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(2005, 200000);
            Console.WriteLine(c);
            Console.WriteLine(c.Start());
            Console.WriteLine(c.Accelerate());

            Truck t = new Truck(2003, 4560000);
            Console.WriteLine(t);
            Console.WriteLine(t.Start());
            Console.WriteLine(t.Accelerate());

            Console.ReadKey();
        }
    }
}
