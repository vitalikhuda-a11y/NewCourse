using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Notifications
{
    public abstract class NotificationBase
    {

        public abstract void Send(string message);

        protected string FormatMessage(string message) => $"[Booking] {message}";

    }


    public interface INotificationChannel
    {
        void Send(string message);
    }
}
