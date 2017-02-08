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
            PayingAccount account = new PayingAccount();
            Assert.AreEqual(0, account.Balance);
        }
        [TestMethod]
        public void Credit_WithAmount_ShouldIncreaseBalanceAndApplyFees()
        {
            PayingAccount account = new PayingAccount(999);
            account.Credit(1000);
            
            Assert.AreEqual(1999 - account.Fee, account.Balance);
        }
        [TestMethod]
        public void Debit_WithAmount_ShouldDecreaseBalanceAndApplyFees()
        {
            PayingAccount account = new PayingAccount(1000);
            account.Debit(999);

            Assert.AreEqual(1 - account.Fee, account.Balance);
        }
    }
}
