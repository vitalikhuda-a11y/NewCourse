using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Check.Discounts
{
    public sealed class PercentageDiscount: IDiscountStrategy
    {
        private  decimal percent;

        public PercentageDiscount(decimal percent)
        {

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.percent = percent;

           

        }

        public decimal ApplyDiscount(decimal originalPrice)
        {

            return originalPrice - (originalPrice * percent / 100);


        }


        public string Description
        {
            get
            {
                return $"{percent}% off";
            }
        }

    }
}
