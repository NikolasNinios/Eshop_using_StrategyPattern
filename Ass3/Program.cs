using Ass3.Models;
using Ass3.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass3.Enums;
using Ass3.EshopContext;
using Ass3.PaymentMethodStrategy;

namespace Ass3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IVariationStrategy> ShopVariations = new List<IVariationStrategy>()
            {
                new ColorVariationStrategy(),
                new SizeVariationStrategy(),
                new FabricVariationStrategy()
            };

            TShirt shirt = new TShirt(Color.BLUE, Fabric.CASHMERE, Size.L);

            var eshop = new Eshop();
            eshop.SetVariation(ShopVariations);
            eshop.CalculateCost(shirt);
            Console.WriteLine("Choose Payment Method");
            Console.WriteLine("1 - Bank Transfer");
            Console.WriteLine("2 - Cash");
            Console.WriteLine("3 - Debit");
            Console.WriteLine("4 - Exit");
            string choice = Console.ReadLine();


            switch(choice)
            {
                case "1": eshop.SetPaymentMethod(new BankTransferStrategy());break;
                case "2": eshop.SetPaymentMethod(new CashStrategy());break;
                case "3": eshop.SetPaymentMethod(new DebitCardStrategy());break;
                case "4": Console.WriteLine("User Exiting");break;
                default: Console.WriteLine("Invalid input");break;
            }

            eshop.PayTShirt(shirt.Price);

        }
    }
}
