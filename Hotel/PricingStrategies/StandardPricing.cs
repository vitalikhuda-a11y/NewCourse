using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.PricingStrategies
{
    public class StandardPricing : IRoomPricingStrategy
    {

        public Money CalculatePrice(BookingRequest request)
        {

            int night = request.CheckOut.DayNumber - request.CheckIn.DayNumber;
            return new Money(night * 100, "USD");

        }


        public string StrategyName
        {
            get
            {

                return "Standard";
            }


        }
    }
}