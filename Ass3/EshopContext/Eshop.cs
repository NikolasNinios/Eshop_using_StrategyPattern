using Ass3.Models;
using Ass3.PaymentMethodStrategy;
using Ass3.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.EshopContext
{
    class Eshop
    {
        private IEnumerable<IVariationStrategy> variations;
        private IPaymentMethodStrategy paymentMethod;

        public void SetPaymentMethod (IPaymentMethodStrategy method)
        {
            paymentMethod = method;
        }

        public void SetVariation(IEnumerable<IVariationStrategy> variationStrategies)
        {
            variations = variationStrategies;
        }

        public void CalculateCost(TShirt tshirt)
        {
            foreach (var variation in variations)
            {
                variation.Cost(tshirt);
            }

            Console.WriteLine($"T-Shirt final price is {tshirt.Price} euros");
        }
        public void PayTShirt(decimal price)
        {
            if (paymentMethod.Pay(price))
            {
                Console.WriteLine("Transaction was Successfull");
            }
            else
            {
                Console.WriteLine("Transaction was Declined");
            }
        }

    }
}
