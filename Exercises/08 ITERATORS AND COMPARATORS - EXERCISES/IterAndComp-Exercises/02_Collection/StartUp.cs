using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var collection = new ListyIterator<string>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "END")
                break;

            var tokens = ParseInput(input);
            var command = tokens[0];
            tokens = tokens.Skip(1).ToList();

            try
            {
                switch (command)
                {
                    case "Create":
                        if (tokens.Any())
                        {
                            collection = new ListyIterator<string>(tokens);
                        }

                        break;
                    case "HasNext":
                        Console.WriteLine(collection.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(collection.Move());
                        break;
                    case "Print":
                        collection.Print();
                        break;
                    case "PrintAll":
                        collection.PrintAll();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    private static List<string> ParseInput(string input)
    {
        return input.Split().ToList();
    }
}

