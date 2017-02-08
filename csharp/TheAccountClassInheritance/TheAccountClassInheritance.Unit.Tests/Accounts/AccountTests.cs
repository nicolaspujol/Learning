using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheAccountClassInheritance.Unit.Tests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void CreateAccount_WithoutParams_ShouldSetBalanceToZero()
        {
            Account account = new Account();
            Assert.AreEqual(0, account.Balance);
        }
        [TestMethod]
        public void CreateAccount_WithBalance_ShouldSetBalance()
        {
            Account account = new Account(100);
            Assert.AreEqual(100, account.Balance);
        }
        [TestMethod]
        public void Credit_WithAmount_ShouldIncreaseBalance()
        {
            Account account = new Account(999);
            account.Credit(1000);

            Assert.AreEqual(1999, account.Balance);
        }
        [TestMethod]
        public void Debit_WithAmount_ShouldDecreaseBalance()
        {
            Account account = new Account(1000);
            account.Debit(999);

            Assert.AreEqual(1, account.Balance);
        }
        [TestMethod]
        public void ToString_WithoutParam_ShouldDisplayAccountBalance()
        {
            Account account = new Account(1234);

            Assert.AreEqual("Balance: 1234", account.ToString());
        }
    }
}
