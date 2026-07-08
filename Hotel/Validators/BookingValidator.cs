using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Validators
{
    public class BookingValidator
    {

        public void Validate (BookingRequest request)
        {
            if (request.CheckOut <= request.CheckIn)
            {
                throw new ArgumentException("Invalid dates: CheckOut must be after CheckIn");
            }
        }

    }
}
