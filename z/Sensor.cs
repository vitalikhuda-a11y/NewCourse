using System;
using System.Collections.Generic;
using System.Linq; 

namespace z
{
    public class Program
    {
        public static void Main()
        {
            var bounties = new List<int> { 100, 200, 300 };
            var queries = new List<IEnumerable<int>>();


            for (int i = 1; i <= 3; i++)
            {
               
                queries.Add(bounties.Select(b => b * i));
            }

            foreach (var query in queries)
            {
                foreach (var bounty in query)
                {
                    Console.WriteLine(bounty);
                }
             
            }

            // 1. У Select просто записується дія (помножити на i), але саме множення ще не виконується і результати не запам'ятовуються.
            // 2. Далі цикл for допрацьовує до самого кінця, і змінна "i" доходить до свого фінального значення (стає 4).
            // 3. І коли запускається цикл foreach, тільки тоді починає працювати Select і множити числа. Але він бере вже останнє значення "i" (тобто 4), тому все множиться на 4.



            var sensors = new List<Sensor>
            {
                new Sensor { Id = 1, Temperature = 90, Status = SensorStatus.Online },
                new Sensor { Id = 2, Temperature = 100, Status = SensorStatus.Offline },
                new Sensor { Id = 3, Temperature = 60, Status = SensorStatus.Online }
            };

            var overheating = sensors.Where(s => s.Temperature > 80);
            sensors.RemoveAll(s => s.Status == SensorStatus.Offline);

            foreach (var s in overheating)
            {
                Console.WriteLine($"Датчик {s.Id}: {s.Temperature} градусів");
            }
        }
    }

    public enum SensorStatus
    {
        Online,
        Offline
    }

    public class Sensor
    {
        public int Id { get; set; }
        public int Temperature { get; set; }
        public SensorStatus Status { get; set; }
    }
}

// змінна оверхітінг в нас записано, але ще нічого не виконує і не запам'ятовує, далі в нас видаляється ід 2, бо він офлайн.
//і коли запускається цикл, тільки тоді починає працювати оверхітінг з where і шукати датчики по умові.





