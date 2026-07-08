using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Notifications
{
    public class SmsNotification : NotificationBase, INotificationChannel
    {

        public override void Send(string message)
        {

            

            Console.WriteLine($"Sending SMS: {FormatMessage(message)}");


        }



    }
}
