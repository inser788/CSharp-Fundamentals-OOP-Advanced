using System;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        int iterations = int.Parse(Console.ReadLine());
        var elements =new GenericCollection<string>();
        for (int i = 0; i < iterations; i++)
        {
            elements.AddItem(Console.ReadLine());
        }

        int[] swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        elements.SwapElements(swapIndexes[0],swapIndexes[1]);

        Console.WriteLine(elements.Print());
    }
}

