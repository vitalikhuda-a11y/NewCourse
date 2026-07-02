using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Check.Delivery
{
    public sealed class FreeShipping: IShippingMethod
    {

        public decimal Cost
        {
            get
            {
                return 0;
            }

        }
        public int EstimatedDays
        {

            get
            {
                return 7;
            }

        }
        public string Name
        {
            get
            {
                return "Free Shipping";
            }
        }

    }
}
