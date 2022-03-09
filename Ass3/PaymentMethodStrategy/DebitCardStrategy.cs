using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.PaymentMethodStrategy
{
    class DebitCardStrategy : IPaymentMethodStrategy
    {
        public bool Pay(decimal amount)
        {
            if (amount < 0m || amount > 10000)
            {
                Console.WriteLine($"Paying {amount} using Debit Card Transfer Declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using Debit Card Transfer Accepted");
                return true;
            }
        }
    }
}
