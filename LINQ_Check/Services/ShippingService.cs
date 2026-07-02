using LINQ_Check.Delivery;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Check.Services
{
    public static class ShippingService
    {

        public static bool CanUseFreeShipping (decimal orderTotal , IShippingMethod shipping)
        {

            if (shipping is FreeShipping && orderTotal < 100)
            {
                return false;
            }

            else
            {
                return true;
            }

        }

    }
}
