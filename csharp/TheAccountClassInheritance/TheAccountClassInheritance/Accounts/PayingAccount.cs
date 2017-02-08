using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAccountClassInheritance
{
    public class PayingAccount : Account
    {
        private const double _fee = 5;

        public PayingAccount() : base() { }
        public PayingAccount(double balance) : base(balance) { }

        public double Fee
        {
            get { return _fee; }
            set { }
        }

        public new void Credit(double amount)
        {
            base.Credit(amount);
            base.Debit(_fee);
        }
        public new void Debit(double amount)
        {
            base.Debit(amount + _fee);
        }
    }
}
