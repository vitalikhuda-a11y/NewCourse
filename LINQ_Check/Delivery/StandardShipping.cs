using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Check.Delivery
{
    public sealed class StandardShipping: IShippingMethod
    {


        public decimal Cost
        {
            get
            {
                return 5;
            }

        }
        public int EstimatedDays
        {

            get
            {
                return 5;
            }

        }
        public string Name
        {
            get
            {
                return "Standard Shipping";
            }
        }

    }
}
