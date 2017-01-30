using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheAccountClass.Tests
{
    [TestClass]
    public class AccountTests
    {
        private static int createdAccounts = 0;

        [TestMethod]
        public void CreateAccount()
        {
            Customer customer = new Customer("1234", "firstName", "lastName", "phone");
            Account account = new Account(customer);
            createdAccounts++;
            Assert.AreEqual("Account number: 1\nAccount balance: 0", account.DisplayCurrentAccountData());

            Assert.AreEqual("Created accounts: " + createdAccounts, account.DisplayCreatedAccountsQty());
        }
        [TestMethod]
        public void CreateMultipleAccounts()
        {
            Customer customer = new Customer("1234", "firstName", "lastName", "phone");
            Account account = new Account(customer);
            createdAccounts++;
            Assert.AreEqual("Account number: " + createdAccounts + "\nAccount balance: 0", account.DisplayCurrentAccountData());

            Customer customer2 = new Customer("5678", "firstName2", "lastName2", "phone2");
            Account account2 = new Account(customer2);
            createdAccounts++;
            Assert.AreEqual("Account number: " + createdAccounts + "\nAccount balance: 0", account2.DisplayCurrentAccountData());

            Assert.AreEqual("Created accounts: " + createdAccounts, account.DisplayCreatedAccountsQty());
        }
        [TestMethod]
        public void CreditAccount()
        {
            Customer customer = new Customer("1234", "firstName", "lastName", "phone");
            Account account = new Account(customer);
            createdAccounts++;
            account.Credit(1000);

            Assert.AreEqual("Account number: " + createdAccounts + "\nAccount balance: 1000", account.DisplayCurrentAccountData());
        }
        [TestMethod]
        public void CreditAccountThenDebit()
        {
            Customer customer = new Customer("1234", "firstName", "lastName", "phone");
            Account account = new Account(customer);
            Customer customer2 = new Customer("5678", "firstName2", "lastName2", "phone2");
            Account account2 = new Account(customer2);
            createdAccounts += 2;

            PaymentService paymentService = new PaymentService();
            paymentService.SubmitPayment(account2, account, 1000);

            Assert.AreEqual("Account number: " + (createdAccounts - 1) + "\nAccount balance: 1000", account.DisplayCurrentAccountData());
            Assert.AreEqual("Account number: " + createdAccounts + "\nAccount balance: -1000", account2.DisplayCurrentAccountData());
        }
        [TestMethod]
        public void DebitAccount()
        {
            Customer customer = new Customer("1234", "firstName", "lastName", "phone");
            Account account = new Account(customer);
            createdAccounts++;
            account.Debit(1000);

            Assert.AreEqual("Account number: " + createdAccounts + "\nAccount balance: -1000", account.DisplayCurrentAccountData());
        }
        [TestMethod]
        public void DebitAccountThenCredit()
        {
            Customer customer = new Customer("1234", "firstName", "lastName", "phone");
            Account account = new Account(customer);
            Customer customer2 = new Customer("5678", "firstName2", "lastName2", "phone2");
            Account account2 = new Account(customer2);
            createdAccounts += 2;

            PaymentService paymentService = new PaymentService();
            paymentService.SubmitPayment(account, account2, 1000);

            Assert.AreEqual("Account number: " + (createdAccounts - 1) + "\nAccount balance: -1000", account.DisplayCurrentAccountData());
            Assert.AreEqual("Account number: " + createdAccounts + "\nAccount balance: 1000", account2.DisplayCurrentAccountData());
        }
        [TestMethod]
        public void DisplayCurrentAccountData()
        {
            Customer customer = new Customer("1234", "firstName", "lastName", "phone");
            Account account = new Account(customer);
            createdAccounts++;

            Assert.AreEqual("Account number: " + createdAccounts + "\nAccount balance: 0", account.DisplayCurrentAccountData());
        }
        [TestMethod]
        public void DisplayCreatedAccountsQty()
        {
            Customer customer = new Customer("1234", "firstName", "lastName", "phone");
            Account account = new Account(customer);
            createdAccounts++;

            Assert.AreEqual("Created accounts: " + createdAccounts, account.DisplayCreatedAccountsQty());
        }
        [TestMethod]
        public void DisplayMultipleCreatedAccountsQty()
        {
            Customer customer = new Customer("1234", "firstName", "lastName", "phone");
            Account account = new Account(customer);
            Customer customer2 = new Customer("5678", "firstName2", "lastName2", "phone2");
            Account account2 = new Account(customer2);
            createdAccounts += 2;

            Assert.AreEqual("Created accounts: " + createdAccounts, account.DisplayCreatedAccountsQty());
        }
    }
}
