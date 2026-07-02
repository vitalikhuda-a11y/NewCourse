using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Check.Delivery
{
    public sealed class ExpressShipping: IShippingMethod
    {

        public decimal Cost
        {
            get
            {
                return 15;
            }

        }
        public int EstimatedDays
        {

            get
            {
                return 1;
            }

        }
        public string Name
        {
            get
            {
                return "Express Shipping";
            }
        }

    }
}
