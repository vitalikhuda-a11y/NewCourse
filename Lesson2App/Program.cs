//Блок 2 (1)

using System.Runtime.CompilerServices;

string text = "apple banana apple cherry banana apple";

string[] words = text.Split(' ');
Dictionary<string, int> wordCounts = new Dictionary<string, int>();

foreach (string word in words)
{
    if (wordCounts.ContainsKey(word))
    {
        wordCounts[word]++;
    }
    else
    {
        wordCounts[word] = 1;
    }
}

foreach (var item in wordCounts.OrderByDescending(x => x.Value))
{
    Console.WriteLine(item.Key + " = " + item.Value);
}


//Блок 2 (2)

HashSet<string> firstGroup = new HashSet<string>()
{
    "Anna",
    "Ivan",
    "Oleg",
    "Maria"
};

HashSet<string> secondGroup = new HashSet<string>()
{
   "Ivan",
    "Maria",
    "Dmytro",
    "Sofia"
};

HashSet<string> studentsInBothGroups = new HashSet<string>(firstGroup);
studentsInBothGroups.IntersectWith(secondGroup);
Console.WriteLine("Студентів що є в обох групах: ");

foreach (string student in studentsInBothGroups)
{
    Console.WriteLine(student);
}

HashSet<string> studentsInFirstGroup = new HashSet<string>(firstGroup);
studentsInFirstGroup.ExceptWith(secondGroup);
Console.WriteLine("Студенти які є тільки в першій групі: ");

foreach (string student in studentsInFirstGroup)
{
    Console.WriteLine(student);

}

HashSet<string> allUniqueStudents = new HashSet<string>(firstGroup);
allUniqueStudents.UnionWith(secondGroup);
Console.WriteLine("Усі унікальні студенти разом: ");

foreach (string student in allUniqueStudents)
{
    Console.WriteLine(student);

}

//Блок 3 (1)

static void Swap<T>(ref T firstValue, ref T secondValue)
{
    T temp = firstValue;
    firstValue = secondValue;
    secondValue = temp;
}

int a = 5, b = 10;
Swap(ref a, ref b);
Console.WriteLine($"a = {a}, b = {b}");

string x = "hello", y = "world";
Swap(ref x, ref y);
Console.WriteLine($"x = {x}, y = {y}");

//Блок 3 (2)


MyStack<int> numbers = new MyStack<int>();

numbers.Push(10);
numbers.Push(20);
numbers.Push(30);

Console.WriteLine(numbers.Peek());

Console.WriteLine(numbers.Pop());
Console.WriteLine(numbers.Pop());

Console.WriteLine(numbers.IsEmpty);



MyStack<string> wordStack = new MyStack<string>();

wordStack.Push("hello");
wordStack.Push("world");

Console.WriteLine(wordStack.Peek());

Console.WriteLine(wordStack.Pop());
Console.WriteLine(wordStack.Pop());

Console.WriteLine(wordStack.IsEmpty);

class MyStack<T>
{
    private List<T> items = new List<T>();

    public bool IsEmpty
    {
        get
        {
            return items.Count == 0;
        }
    }


    public void Push(T item)
    {
        items.Add(item);
    }


    public T Pop()
    {
        int lastIndex = items.Count - 1;
        T lastItem = items[lastIndex];

        items.RemoveAt(lastIndex);

        return lastItem;

    }

    public T Peek()
    {
        int lastIndex = items.Count - 1;

        return items[lastIndex];
    }

}