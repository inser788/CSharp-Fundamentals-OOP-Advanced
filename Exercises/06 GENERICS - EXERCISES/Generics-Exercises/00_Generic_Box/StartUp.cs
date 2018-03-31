    using System;

public class StartUp
{
    static void Main()
    {
        var box = new Box<string>(Console.ReadLine());
        Console.WriteLine(box.ToString());
    }
}

