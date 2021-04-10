using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        private const int comfortIn = 5;
        private const decimal priceIn = 10;

        public Plant()
            : base(comfortIn, priceIn)
        {
        }
    }
}
