using System;

public class Booking
{
    public Guid Id { get; init; }
    public BookingRequest Request { get; init; } = null!;
    public BookingStatus Status { get; private set; } = BookingStatus.Pending;
    public void Confirm() => Status = BookingStatus.Confirmed;
    public void Cancel() => Status = BookingStatus.Cancelled;
}
public enum BookingStatus { Pending, Confirmed, Cancelled }