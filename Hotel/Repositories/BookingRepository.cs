using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Repositories
{
    public class BookingRepository
    {

        public void Save (BookingRequest request, decimal price)
        {
            Console.WriteLine($"Saved booking for room {request.RoomId}, total: {price}");
        }

    }
}
