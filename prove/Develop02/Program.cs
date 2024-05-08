using System;
using System.IO;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        List<string> _entries = new List<string>();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please Select one of the following choices");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine("Prompt: " + prompt);
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, response);
                    journal.AddEntry(newEntry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("Enter the filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case 4:
                    Console.Write("Enter the filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }

        }
    }
}