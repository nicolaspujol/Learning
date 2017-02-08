using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAccountClassInheritance
{
    public class Account
    {
        protected double _balance;
        private int _accountNumber;
        private static int _accountQty = 0;

        public double Balance
        {
            get { return _balance; }
            set { }
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { }
        }

        public Account()
        {
            _balance = 0;
            _accountNumber = ++_accountQty;
        }
        public Account(double balance)
        {
            _balance = balance;
            _accountNumber = ++_accountQty;
        }

        public void Credit(double amount)
        {
            _balance += amount;
        }
        public void Debit(double amount)
        {
            _balance -= amount;
        }
        public override string ToString()
        {
            return $"Balance: {_balance}";
        }
    }
}
