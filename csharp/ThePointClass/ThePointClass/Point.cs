using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePointClass
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public double Distance()
        {
            return Math.Sqrt(Math.Pow(this._x, 2) + Math.Pow(this._y, 2));
        }
    }
}
