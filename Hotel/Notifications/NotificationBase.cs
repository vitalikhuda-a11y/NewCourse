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


////Абстрактний клас потрібен, щоб один раз написати код форматування і не копіювати його в кожен новий клас. А інтерфейс діє як суворе правило: він гарантує, що кожен канал зв'язку точно має метод Send.
//Оскільки в C# клас може мати лише одного "батька", якби EmailNotification успадкував інший клас, він би втратив доступ до нашого абстрактного класу. Але завдяки інтерфейсу (яких можна підключати скільки завгодно), програма все одно змогла б працювати з цим імейлом як зі звичайною нотифікацією.