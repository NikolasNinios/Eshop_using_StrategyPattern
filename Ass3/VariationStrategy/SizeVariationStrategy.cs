using Ass3.Enums;
using Ass3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.VariationStrategy
{
   public class SizeVariationStrategy : IVariationStrategy
   {
       //Price Tag
       private static Dictionary<Size, decimal> sizeVariations;
       static SizeVariationStrategy()
       {
           sizeVariations = new Dictionary<Size, decimal>()
           {
               {Size.XS,1m },
               {Size.S,2m },
               {Size.M,3m },
               {Size.L,4m },
               {Size.XL,5m },
               {Size.XXL,6m },
               {Size.XXXL,7m },
           };
       }
       public void Cost(TShirt Tshirt)
       {
           Tshirt.Price += sizeVariations[Tshirt.Size];
       }
   }
  
}
