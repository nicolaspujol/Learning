using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVehicleAbstractClass.Vehicles
{
    public abstract class Vehicle
    {
        private static int _totalRegistrations = 0;
        private int _registrationNumber;
        private int _year;
        private double _price;

        public int RegistrationNumber
        {
            get { return _registrationNumber; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public static int TotalRegistrations
        {
            get { return _totalRegistrations; }
        }

        public Vehicle(int year, double price)
        {
            _registrationNumber = ++_totalRegistrations;
            _year = year;
            _price = price;
        }

        public abstract string Start();
        public abstract string Accelerate();

        public override string ToString()
        {
            return $"Registration number: {_registrationNumber}, Year: {_year}, Price: {_price}";
        }
    }
}
