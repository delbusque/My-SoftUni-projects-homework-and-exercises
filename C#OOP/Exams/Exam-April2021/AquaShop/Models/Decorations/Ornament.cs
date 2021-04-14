using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Ornament : Decoration
    {
        private const int comfortIn = 1;
        private const decimal priceIn = 5;
        
        public Ornament() 
            : base(comfortIn, priceIn)
        {
        }
    }
}
