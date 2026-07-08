using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Notifications
{
    public class EmailNotification : NotificationBase, INotificationChannel
    {

        public override void Send(string message)
        {

            string formattedText = FormatMessage(message);

            
            Console.WriteLine($"Sending Email: {formattedText}");

        }


  
    }
}
