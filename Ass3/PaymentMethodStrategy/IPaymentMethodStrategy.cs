using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.PaymentMethodStrategy
{
    public interface IPaymentMethodStrategy
    {
        bool Pay(decimal amount);
    }
}
