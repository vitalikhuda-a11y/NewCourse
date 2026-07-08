using Hotel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Service
{
    public class SimpleBookingBot: IBookingCreation, IBookingCancellation
    {

        public void Create(BookingRequest request)
        {
            Console.WriteLine("The booking has been created");
        }

        public void Cancel(Guid bookingId)
        {
            Console.WriteLine("The booking has been cancelled");
        }

    }
}
