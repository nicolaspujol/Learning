using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Define a Point class
Define a method to return the distance between the origin (0, 0) and a created point
*/
namespace ThePointClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = GetPoint("x");
            int y = GetPoint("y");

            Point point = new Point(x, y);
            Console.WriteLine(point.Distance());

            Console.ReadKey();
        }

        private static int GetPoint(string pointName)
        {
            int point;
            Console.Write($"Define {pointName} position:");
            try
            {
                point = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                throw new FormatException("Int expected", e);
            }

            return point;
        }
    }
}
