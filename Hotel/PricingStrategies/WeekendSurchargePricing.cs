using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.PricingStrategies
{
    public class WeekendSurchargePricing : IRoomPricingStrategy
    {

        public Money CalculatePrice(BookingRequest request)
        {

            int night = request.CheckOut.DayNumber - request.CheckIn.DayNumber;
            if (request.CheckIn.DayOfWeek == DayOfWeek.Friday || request.CheckIn.DayOfWeek == DayOfWeek.Saturday)
            {
                return new Money(1.2m * (night * 100), "USD");
            }

            else
            {
                return new Money(night * 100, "USD");
            }

        }


        public string StrategyName
        {
            get
            {

                return "Weekend Surcharge";
            }

        }
    }
}
