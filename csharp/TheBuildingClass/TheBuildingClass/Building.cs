using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBuildingClass
{
    public class Building
    {
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public Building() { }

        public Building(string address)
        {
            _address = address;
        }

        public override string ToString()
        {
            return "Address: " + _address;
        }
    }
}
