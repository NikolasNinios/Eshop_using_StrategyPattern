using Ass3.Enums;
using Ass3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.VariationStrategy
{
    public class ColorVariationStrategy : IVariationStrategy
    {
        //Price Tag
        private static Dictionary<Color, decimal> colorVariations;
        static ColorVariationStrategy()
        {
            colorVariations = new Dictionary<Color, decimal>()
            {
                {Color.BLUE,1m },
                {Color.GREEN,2m },
                {Color.INDIGO,3m },
                {Color.ORANGE,4m },
                {Color.RED,5m },
                {Color.VIOLET,6m },
                {Color.YELLOW,7m },
            };
        }
        public void Cost(TShirt Tshirt)
        {
            Tshirt.Price += colorVariations[Tshirt.Color];
        }
    }
}
