using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAccountClass
{
    public class Customer
    {
        private string _idNumber;
        private string _firstName;
        private string _lastName;
        private string _phone;

        public Customer(string idNumber, string firstName, string lastName, string phone)
        {
            _idNumber = idNumber;
            _firstName = firstName;
            _lastName = lastName;
            _phone = phone;
        }
        public Customer(string idNumber, string firstName, string lastName)
        {
            _idNumber = idNumber;
            _firstName = firstName;
            _lastName = lastName;
        }

        public string DisplayCurrentCustomerData() {
            return $"Account owner:\nId number: {_idNumber}\nLast name: {_lastName}\nFirst name: {_firstName}\nPhone: {_phone}";
        }
    }
}
