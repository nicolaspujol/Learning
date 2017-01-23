using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAccountClass
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Account " + i + ":");
                Customer customer = AddCustomer();
                Console.WriteLine(customer.DisplayCurrentCustomerData());
            }
            Console.ReadKey();
        }
        private static Customer AddCustomer()
        {
            string idNumber = GetCustomerData("Id number");
            string firstName = GetCustomerData("First name");
            string lastName = GetCustomerData("Last name");
            string phone = GetCustomerData("Phone");

            return new Customer(idNumber, firstName, lastName, phone);
        }

        private static string GetCustomerData(string expectedData)
        {
            Console.WriteLine($"{expectedData}?");
            return Console.ReadLine();
        }
    }
}
