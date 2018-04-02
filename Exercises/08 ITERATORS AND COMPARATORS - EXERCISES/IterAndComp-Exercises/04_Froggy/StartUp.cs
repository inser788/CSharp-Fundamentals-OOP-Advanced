using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var collection = Console.ReadLine()
            .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var result=new Lake(collection);

        Console.WriteLine(string.Join(", ",result));
    }
}

