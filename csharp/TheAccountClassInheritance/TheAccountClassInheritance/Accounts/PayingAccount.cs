using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAccountClassInheritance
{
    public class PayingAccount : Account
    {
        private const int _fee = 5;

        public PayingAccount() : base() { }
        public PayingAccount(double balance) : base(balance) { }

        public new void Credit(double amount)
        {
            _balance += amount - 5;
        }
        public new void Debit(double amount)
        {
            _balance -= amount + 5;
        }
    }
}
