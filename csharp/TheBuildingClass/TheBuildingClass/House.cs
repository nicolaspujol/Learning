using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBuildingClass
{
    public class House : Building
    {
        private int _rooms;
        public House() : base() { }

        public House(string address, int rooms) : base(address)
        {
            Rooms = rooms;
        }

        public int Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ", Rooms: " + Rooms;
        }
    }
}
