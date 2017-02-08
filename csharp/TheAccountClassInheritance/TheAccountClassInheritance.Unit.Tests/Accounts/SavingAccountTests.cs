using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheAccountClassInheritance.Unit.Tests.Accounts
{
    [TestClass]
    public class SavingAccountTests
    {
        [TestMethod]
        public void CreateAccount_WithoutParams_ShouldSetBalanceToZero()
        {
            SavingAccount account = new SavingAccount(13);
            Assert.AreEqual(0, account.Balance);
        }
        [TestMethod]
        public void CreateAccount_WithInterrestRate_ShouldSetInterrestRate()
        {
            SavingAccount account = new SavingAccount(6);
            Assert.AreEqual(6, account.InterrestRate);
        }
        [TestMethod]
        public void CreateAccount_WithInterrestRateAndBalance_ShouldSetInterrestRateAndBalance()
        {
            SavingAccount account = new SavingAccount(111, 222);
            Assert.AreEqual(111, account.Balance);
            Assert.AreEqual(222, account.InterrestRate);
        }
        [TestMethod]
        public void UpdateInterest_WithoutParams_ShouldIncreaseBalanceByInterest()
        {
            SavingAccount account = new SavingAccount(300, 10);
            account.UpdateInterests();
            Assert.AreEqual(330, account.Balance);
        }
    }
}
