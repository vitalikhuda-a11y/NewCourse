/* Задача 1 */

{
    int age = 18;
    string userName = "Vitalii";
    bool isRight = true;
    double percent = 90.9;

    Console.WriteLine(age);
    Console.WriteLine(userName);
    Console.WriteLine(isRight);
    Console.WriteLine(percent);

    Console.WriteLine("Якщо присвоїти null до int, буде помилка, тому що int має містити числове значення, а null означає відсутність значення.");
}


/* Задача 2 */

{
    Console.WriteLine("Введіть свій вік:");
    int userAge = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Мені " + userAge);

    Console.WriteLine("Введіть число:");
    int number = int.Parse(Console.ReadLine()!);

    if (number % 2 == 0)
    {
        Console.WriteLine("Парне");
    }
    else
    {
        Console.WriteLine("Непарне");
    }

    Console.WriteLine("Введіть нове число:");
    int limitNumber = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Цикл через for:");

    for (int i = 1; i <= limitNumber; i++)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Цикл через while:");

    int j = 1;

    while (j <= limitNumber)
    {
        Console.WriteLine(j);
        j++;
    }
}


/* Задача 3 */

{
    int sumResult = Add(5, 3);
    Console.WriteLine(sumResult);

    string greetingMessage = Greet("Vitalii");
    Console.WriteLine(greetingMessage);
}




static int Add(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}

static string Greet(string name)
{
    return "Привіт " + name;
}


/* Задача 4 */

{
    int[] numbers = { 4, 30, -5, 0, 6 };

    int maxNumber = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > maxNumber)
        {
            maxNumber = numbers[i];
        }
    }

    Console.WriteLine("Максимальне число = " + maxNumber);

    List<string> names = new List<string>();

    names.Add("Vitalii");
    names.Add("Alex");
    names.Add("Bob");

    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}


/* Задача 5 */





Person firstPerson = new Person("Vitalii", 19);
Person secondPerson = new Person("Alex", 25);

firstPerson.Introduce();
secondPerson.Introduce();

/* Клас для задачі 5 */

class Person
{

    private int ageValue;
    public string Name { get; private set; }
    public int Age
    {
        get
        {
            return ageValue;
        }
        set
        {
            if (value >= 0)
            {
                ageValue = value;
            }
            else
            {
                Console.WriteLine("Вік не може бути від'ємним");
            }
        }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Привіт, я {Name}, мені {Age} років");
    }
}