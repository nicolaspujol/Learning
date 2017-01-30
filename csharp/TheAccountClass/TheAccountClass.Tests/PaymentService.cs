using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheAccountClass.Tests
{
    [TestClass]
    public class PaymentServiceTests
    {
        [TestMethod]
        public void SubmitPayment_ShouldDebitFromAndCreditTo()
        {
            Customer customer1 = new Customer("1", "John", "Doe", "06");
            Account account1 = new Account(customer1);
            account1.Credit(1111);

            Customer customer2 = new Customer("2", "Jane", "Doe", "07");
            Account account2 = new Account(customer2);
            account2.Credit(2222);

            PaymentService paymentService = new PaymentService();
            paymentService.SubmitPayment(account1, account2, 1000);

            Assert.AreEqual(111, account1.Balance);
            Assert.AreEqual(3222, account2.Balance);
        }
    }
}
