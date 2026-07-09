using Hotel.PricingStrategies;

 Money CalulateTotal (IRoomPricingStrategy strategy, BookingRequest request)
{
    return strategy.CalculatePrice(request);
}