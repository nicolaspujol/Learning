using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheAccountClass.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void DisplayCurrentCustomerData()
        {
            Customer customer = new Customer("1234", "firstName", "lastName", "phone");
            Assert.AreEqual("Account owner:\nId number: 1234\nLast name: lastName\nFirst name: firstName\nPhone: phone", customer.DisplayCurrentCustomerData());
        }
        [TestMethod]
        public void DisplayCurrentCustomerDataNoPhone()
        {
            Customer customer = new Customer("1234", "firstName", "lastName");
            Assert.AreEqual("Account owner:\nId number: 1234\nLast name: lastName\nFirst name: firstName\nPhone: ", customer.DisplayCurrentCustomerData());
        }
    }
}
