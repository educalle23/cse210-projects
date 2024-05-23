using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (!scripture.AreAllWordsHidden())
        {
            scripture.Display();
            Console.WriteLine("Type 'hide' to hide words or 'quit' to exit:");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
                break;
            else
                scripture.HideRandomWords(2);
        }
        Console.WriteLine("All words are hidden. Press any key to exit.");
        Console.ReadKey();
    }
}