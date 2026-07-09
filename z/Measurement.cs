using System;
using System.Collections.Generic;
using System.Text;

namespace z
{
    public class Measurement
    {
     
           
            public DateTime Timestamp { get; set; }
            public int Value { get; set; }
            public IEnumerable<Measurement> GetRecent(IQueryable<Measurement> source, int days)
        {
            return source
                .Where(m => m.Timestamp > DateTime.Now.AddDays(-days))
                .Where(m => m.Value >= 0 && m.Value < 1000) // Ось вона, чиста фільтрація для БД
                .OrderByDescending(m => m.Timestamp);
        }

    }
}

// Виконання в пам'яті почнеться на рядку .Where(m => IsValid(m)). База даних (і EF) не знає, що таке локальний C#-метод IsValid і не може перекласти його на SQL. Тому програма витягне всі дані з бази в оперативну пам'ять і почне фільтрувати їх там, що вбиває продуктивність.
 // Правило використання IQueryable:
// 1. Безпечно: використовувати тільки всередині самого репозиторію, щоб зручно зібрати запит по частинах.
// 2. Витік абстракції (погано): повертати IQueryable з репозиторію назовні (у бізнес-логіку). 
// бо тоді інший код змушений сам працювати з базою даних і завершувати запит, хоча він взагалі не повинен знати про існування БД. Назовні треба віддавати вже готові дані (IEnumerable).