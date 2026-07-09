using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Check.Discounts
{
    public interface IDiscountStrategy
    {

        decimal ApplyDiscount(decimal originalPrice);
        string Description { get; }

    }
}
