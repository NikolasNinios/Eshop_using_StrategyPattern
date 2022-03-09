using Ass3.Enums;
using Ass3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.VariationStrategy
{
    public class FabricVariationStrategy : IVariationStrategy
    {
        //Price Tag
        private static Dictionary<Fabric, decimal> fabricVariations;
        static FabricVariationStrategy()
        {
            fabricVariations = new Dictionary<Fabric, decimal>()
            {
                {Fabric.CASHMERE,1m },
                {Fabric.COTTON,2m },
                {Fabric.LINEN,3m },
                {Fabric.POLYESTER,4m },
                {Fabric.RAYON,5m },
                {Fabric.SILK,6m },
                {Fabric.WOOL,7m },
            };
        }
        public void Cost(TShirt Tshirt)
        {
            Tshirt.Price += fabricVariations[Tshirt.Fabric];
        }
    }   
}
