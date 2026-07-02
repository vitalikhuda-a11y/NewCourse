using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Check.Delivery
{
    public interface IShippingMethod
    {

        decimal Cost { get; }
        int EstimatedDays { get; }
        string Name { get; }

    }
}
