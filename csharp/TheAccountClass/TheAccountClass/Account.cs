using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAccountClass
{
    public class Account
    {
        private double _balance;
        private int _accountNumber;
        private Customer _owner;
        private static int _accountQty = 0;

        public double Balance
        {
            get { return _balance; } 
            set { }
        }

        public Account(Customer owner) {
            _balance = 0;
            _accountNumber = ++_accountQty;
            _owner = owner;
        }

        public void Credit(double amount)
        {
            _balance += amount;
        }
        public void Credit(double amount, Account account)
        {
            PaymentService paymentService = new PaymentService();
            paymentService.SubmitPayment(account, this, amount);
        }
        public void Debit(double amount)
        {
            _balance -= amount;
        }
        public void Debit(double amount, Account account)
        {
            PaymentService paymentService = new PaymentService();
            paymentService.SubmitPayment(this, account, amount);
        }
        public string DisplayCurrentAccountData()
        {
            return $"Account number: {_accountNumber}\nAccount balance: {_balance}";
        }
        public string DisplayCreatedAccountsQty()
        {
            return $"Created accounts: {_accountQty}";
        }
    }
}
