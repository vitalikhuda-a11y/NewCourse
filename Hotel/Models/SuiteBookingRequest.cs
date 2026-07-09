using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Models
{
    public record SuiteBookingRequest: BookingRequest
    {

        public bool HasButlerService { get; set; }

        public SuiteBookingRequest (Guid roomId, DateOnly checkIn, DateOnly checkOut, int guestsCount, bool hasButlerService) : base(roomId, checkIn, checkOut, guestsCount)
        {

            HasButlerService = hasButlerService;

        }

    }
}
