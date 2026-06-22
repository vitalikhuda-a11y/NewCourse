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