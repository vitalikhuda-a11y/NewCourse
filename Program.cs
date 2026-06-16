/* Задача 1 */


/* int age = 18;
string name = "Vitalii";
bool isRight = true;
double percent = 90.9;


Console.WriteLine(age);
Console.WriteLine(name);
Console.WriteLine(isRight);
Console.WriteLine(percent);

/* спробував присвоїти null до int, але написало, що Cannot convert null to 'int', тому що змінна int має мати якесь значення, а null означає, що значення немає */

/* Задача 2 */

/* Console.WriteLine("Введіть свій вік:");
int aget = int.Parse(Console.ReadLine());
Console.WriteLine("мені " + aget);


Console.WriteLine("Введіть число");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)

{

    Console.WriteLine("Парне");

}
else
{
    Console.WriteLine("Непарне");
}
 */

/* Console.WriteLine("Введіть нова число");
int newnum = int.Parse(Console.ReadLine());
Console.WriteLine("Цикл через for:");

for (int i = 1; i <= newnum; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine("Цикл через while:");

int j = 1;

while (j <= newnum)
{
    Console.WriteLine(j);
    j++;
} */


/* Задача 3 */

/* 
int rez = Add(5, 3);
Console.WriteLine(rez);

string greeting = Greet("Vitalii");
Console.WriteLine(greeting);


static int Add(int a, int b)
{
    return a + b;
}

static string Greet(string name)
{
    return "Привіт " + name;
}
 */



/*  Задача 4 */

/* int[] nums = { 4, 30, -5, 0, 6 };

int max = nums[0];

for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
}
Console.WriteLine("Максимальне число = " + max);

List<string> names = new List<string>();

names.Add("Vitalii");
names.Add("Alex");
names.Add("Bob");

foreach (string name in names)
{
    Console.WriteLine(name);
} */


/*  Задача 5 */



Person per1 = new Person("Vitalii", 19);
Person per2 = new Person("Alex", 25);

per1.Introduce();
per2.Introduce();

class Person
{
    public string Name;
    public int Age;

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