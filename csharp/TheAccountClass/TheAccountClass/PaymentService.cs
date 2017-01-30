using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAccountClass
{
    public class PaymentService
    {
        public void SubmitPayment(Account from, Account to, double amount)
        {
            from.Debit(amount);
            to.Credit(amount);
        }
    }
}
