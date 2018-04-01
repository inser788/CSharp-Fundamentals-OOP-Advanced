using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

public class StartUp
{
    static void Main()
    {
        Student st1 = new Student("pesho", 24, "ab231");
        Student st2 = new Student("gosho", 21, "assss231");
        Student st3 = new Student("stamat", 19, "b3444");

        University unifff=new University();

        unifff.AddStudent(st1);
        unifff.AddStudent(st2);
        unifff.AddStudent(st3);

        var test = new string[] {"gosho", "dani", "ani", "ivan"};
        
        PrintData("prefix",test);
    }

    public static void PrintData(string prefix, params string[] students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"{prefix}  ---{student}");
        }
    }
}

