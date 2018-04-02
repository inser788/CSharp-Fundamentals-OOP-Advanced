using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var personsByName = new SortedSet<Person>(new NameComparator());
        var personsByAge = new SortedSet<Person>(new AgeComparator());

        int numberOfPersons = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfPersons; i++)
        {
            var tokens = Console.ReadLine().Split();
            string name = tokens[0];
            int age = int.Parse(tokens[1]);
            Person person=new Person(name,age);
            personsByName.Add(person);
            personsByAge.Add(person);
        }
        PrintData(personsByName);
        PrintData(personsByAge);
    }

    public static void PrintData(IEnumerable<Person> persons)
    {
        foreach (var person in persons)
        {
            Console.WriteLine(person.ToString());
        }
    }
}

