using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.PaymentMethodStrategy
{
    class BankTransferStrategy : IPaymentMethodStrategy
    {
        public bool Pay(decimal amount)
        {
            if (amount < 0m || amount > 10000)
            {
                Console.WriteLine($"Paying {amount} using Bank Transfer Declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using Bank Transfer Accepted");
                return true;
            }
        }
    }
}
