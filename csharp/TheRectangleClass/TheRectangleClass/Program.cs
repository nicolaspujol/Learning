using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRectangleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Rectangle " + i + ":");
                Rectangle rectangle = AddRectangle();
                Console.WriteLine(rectangle.DisplayRectangleData());
            }
            Console.ReadKey();
        }
        private static Rectangle AddRectangle()
        {
            int rectangleLength = Int32.Parse(GetRectangleData("Length"));
            int rectangleWidth = Int32.Parse(GetRectangleData("Width"));

            return new Rectangle(rectangleLength, rectangleWidth);
        }

        private static string GetRectangleData(string expectedData)
        {
            Console.WriteLine($"{expectedData}?");
            return Console.ReadLine();
        }
    }
}
