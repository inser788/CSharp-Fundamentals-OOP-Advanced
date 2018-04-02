using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var persons = GetPersonsList();

        int searchedIndex = int.Parse(Console.ReadLine()) - 1;

        if (searchedIndex >= 0 && searchedIndex < persons.Count)
        {
            var person = persons[searchedIndex];
            var matchingPersons = persons.Count(p => p.CompareTo(person) == 0);

            Console.WriteLine(matchingPersons == 1
                ? "No matches"
                : $"{matchingPersons} {persons.Count - matchingPersons} {persons.Count}");
        }

    }

    private static List<Person> GetPersonsList()
    {
        var listPersons = new List<Person>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
                break;
            var tokens = input.Split();
            Person person = new Person(tokens[0], int.Parse(tokens[1]), tokens[2]);
            listPersons.Add(person);
        }

        return listPersons;
    }
}

