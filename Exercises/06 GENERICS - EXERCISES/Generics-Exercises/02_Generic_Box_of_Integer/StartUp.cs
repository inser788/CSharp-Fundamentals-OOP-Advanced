    using System;

class StartUp
{
    static void Main()
    {
        int iterations = int.Parse(Console.ReadLine());
        for (int i = 0; i < iterations; i++)
        {
            var box = new Box<int>(int.Parse(Console.ReadLine()));
            Console.WriteLine(box.ToString());
        }
    }
}

