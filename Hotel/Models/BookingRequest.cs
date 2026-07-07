using System;

public record BookingRequest
{


    public Guid RoomId { get; init; }
    public DateOnly CheckIn { get; init; }
    public DateOnly CheckOut { get; init; }
    public int GuestsCount { get; init; }



    public BookingRequest(Guid roomId, DateOnly checkIn, DateOnly checkOut, int guestsCount)

    {
        // тут твої if-перевірки

        if (guestsCount <= 0) {
        throw new ArgumentException("Кількість гостей має бути більше нуля");
}

        if (checkIn >= checkOut)
        {
            throw new ArgumentException();
        }

        RoomId = roomId;
        CheckIn = checkIn;
        CheckOut = checkOut;
        GuestsCount = guestsCount;
    }
}