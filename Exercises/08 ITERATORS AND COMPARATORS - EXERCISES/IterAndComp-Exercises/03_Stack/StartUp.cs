using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var customStack = GetStack();
        PrintElements(customStack);
        PrintElements(customStack);
    }

    private static void PrintElements(CustomStack<long> customStack)
    {
        foreach (var element in customStack)
        {
            Console.WriteLine(element);
        }
    }

    private static CustomStack<long> GetStack()
    {
        var customStack = new CustomStack<long>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
                break;
            var tokens = ParseInput(input);
            string command = tokens[0];

            try
            {
                switch (command)
                {
                    case "Push":
                        var elements = tokens.Skip(1).Select(long.Parse).ToList();
                        foreach (var element in elements)
                        {
                            customStack.Push(element);
                        }
                        break;
                    case "Pop":
                        customStack.Pop();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        return customStack;
    }

    private static List<string> ParseInput(string input)
    {
        return input.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
    }
}

