using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Check.Discounts
{
    public sealed class NoDiscount: IDiscountStrategy
    {

        public decimal ApplyDiscount(decimal originalPrice)
        {
            return originalPrice;
        }


        public string Description
        {
            get
            {
                return "No discount";
            }
        }

    }
}
