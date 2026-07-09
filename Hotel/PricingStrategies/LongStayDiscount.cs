using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.PricingStrategies
{
    public class LongStayDiscount
    {

        public Money CalculatePrice(BookingRequest request)
        {

            int night = request.CheckOut.DayNumber - request.CheckIn.DayNumber;
            if (night >= 7)
            {

                return new Money((night * 100) - (0.1m * (night * 100)), "USD");

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

                return "Long stay discount";
            }

        }
    }
}