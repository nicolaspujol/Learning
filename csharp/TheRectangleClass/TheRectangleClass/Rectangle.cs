using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRectangleClass
{
    public class Rectangle
    {
        private int _length;
        private int _width;

        public Rectangle(int length, int width)
        {
            _length = length;
            _width = width;
        }

        public int Perimeter()
        {
            return _length * 2 + _width * 2;
        }
        public int Area()
        {
            return _length * _width;
        }
        public bool IsSquare()
        {
            return _length == _width;
        }
        public string DisplayRectangleData()
        {
            return $"Length: {_length}\nWidth: {_width}\nPerimeter: {Perimeter()}\nArea: {Area()}\nIs a square: {IsSquare()}";
        }
    }
}
