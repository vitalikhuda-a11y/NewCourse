using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.PricingStrategies
{
    public class SuitePricing : IRoomPricingStrategy
    {

        public Money CalculatePrice(BookingRequest request)
        {

            int night = request.CheckOut.DayNumber - request.CheckIn.DayNumber;
            

            if (request is SuiteBookingRequest suiteBookingRequest)
            {

                if (suiteBookingRequest.HasButlerService == true)
                {
                    return new Money(night * 100 + 100, "USD");
                }
                

            }

        }


        public string StrategyName
        {
            get
            {

                return "Suite";
            }


        }
    }
}