﻿using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var personsSortedSet = new SortedSet<Person>();
        var personsHashSet = new HashSet<Person>();

        var numberOfPersons = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfPersons; i++)
        {
            var personTokens = Console.ReadLine().Split();
            var person = new Person(personTokens[0], int.Parse(personTokens[1]));

            personsHashSet.Add(person);
            personsSortedSet.Add(person);
        }

        Console.WriteLine(personsSortedSet.Count);
        Console.WriteLine(personsHashSet.Count);
    }
}

