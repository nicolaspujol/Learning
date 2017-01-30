using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheAccountClassInheritance.Unit.Tests.Accounts
{
    [TestClass]
    public class PayingAccountTests
    {
        [TestMethod]
        public void CreateAccount_WithoutParams_ShouldSetBalanceToZero()
        {
            PayingAccount account = new PayingAccount(13);
            Assert.AreEqual(13, account.Balance);
        }
        [TestMethod]
        public void Credit_WithAmount_ShouldIncreaseBalanceAndApplyFees()
        {
            PayingAccount account = new PayingAccount(999);
            account.Credit(1000);

            Assert.AreEqual(1994, account.Balance);
        }
        [TestMethod]
        public void Debit_WithAmount_ShouldDecreaseBalanceAndApplyFees()
        {
            PayingAccount account = new PayingAccount(1000);
            account.Debit(999);

            Assert.AreEqual(-4, account.Balance);
        }
    }
}
