using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAccountClassInheritance
{
    public class SavingAccount : Account
    {
        private int _interrestRate;

        public int InterrestRate
        {
            get { return _interrestRate; }
            set { }
        }

        public SavingAccount(int interrestRate) : base()
        {
            _interrestRate = interrestRate;
        }
        public SavingAccount(double balance, int interrestRate) : base(balance)
        {
            _interrestRate = interrestRate;
        }

        public void UpdateInterests()
        {
            Credit(_balance * _interrestRate / 100);
        }
    }
}
