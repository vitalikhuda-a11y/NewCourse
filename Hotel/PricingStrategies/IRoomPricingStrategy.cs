using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.PricingStrategies
{
    public interface IRoomPricingStrategy
    {

        Money CalculatePrice(BookingRequest request);
        string StrategyName { get; }

    }
}
