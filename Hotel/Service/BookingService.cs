using Hotel.Notifications; // Додаємо твої папки, якщо вони є
using Hotel.PricingStrategies;
using Hotel.Repositories;
using Hotel.Validators;
using System;

namespace Hotel.Services
{
    public class BookingService
    {
   
        private readonly BookingValidator _validator;
        private readonly IRoomPricingStrategy _pricingStrategy;
        private readonly BookingRepository _repository;
        private readonly INotificationChannel _notificationChannel;

        public BookingService(
            BookingValidator validator,
            IRoomPricingStrategy pricingStrategy,
            BookingRepository repository,
            INotificationChannel notificationChannel)
        {
            _validator = validator;
            _pricingStrategy = pricingStrategy;
            _repository = repository;
            _notificationChannel = notificationChannel;
        }

      
        public void CreateBooking(BookingRequest request)
        {
           
            _validator.Validate(request);

            Money price = _pricingStrategy.CalculatePrice(request);

            _repository.Save(request, price);

            _notificationChannel.Send($"Email sent: your booking is confirmed, total {price}");
        }
    }
}