using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBuildingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("London");
            Console.WriteLine(building.ToString());
            House house1 = new House("London", 4);
            Console.WriteLine(house1.ToString());
            House house2 = new House();
            house2.Address = "Paris";
            house2.Rooms = 3;
            Console.WriteLine(house2.ToString());
            Console.ReadKey();
        }
    }
}
