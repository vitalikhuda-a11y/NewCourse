using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Check.Discounts
{
    public sealed class FixedAmountDiscount : IDiscountStrategy
    {
        private decimal amount;

        public FixedAmountDiscount(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException();
            }

            this.amount = amount;


        }

        public decimal ApplyDiscount(decimal originalPrice)
        {
            decimal FinalPrice = originalPrice - amount;

            if (FinalPrice < 0)
            {
                return 0;
            }

            else
            {
                return FinalPrice;
            }

        }



        public string Description
        {
            get
            {

                return $"${amount} off";

            }
        }
    }
}