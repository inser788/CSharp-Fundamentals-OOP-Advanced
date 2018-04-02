using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Student st1 = new Student("pesho", 24, "ab231");
        Student st2 = new Student("gosho", 24, "assss231");

        var sortStud = new SortedSet<Student>(new StudentComparator());
        sortStud.Add(st1);
        sortStud.Add(st2);

        foreach (var st in sortStud)
        {
            Console.WriteLine(st.Name);
        }
    }
}

