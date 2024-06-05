using System;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture lecture = new Lecture("Vargas signature", "Vargas will present and sign his new book The City of Cats.", new DateTime(2024, 6, 15), "10:00 AM", "Av. Venezuela", "Vargas Llosa", 100);
            Reception reception = new Reception("They don't Know me son!", "An opportunity to recharge your energy and be unbeatable", new DateTime(2024, 6, 20), "6:00 PM", "456 Elm St", "RSPV by goggins@example.com");
            OutdoorGathering outdoorGathering = new OutdoorGathering("Community Brunch", "A Brunch for the whole community.", new DateTime(2024, 7, 4), "12:00 PM", "789 Park Ave", "Sunny");

            while (true)
            {
                Console.WriteLine("\nEvent Planning Menu:");
                Console.WriteLine("1. Display Lecture Details");
                Console.WriteLine("2. Display Reception Details");
                Console.WriteLine("3. Display Outdoor Gathering Details");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayEventDetails(lecture);
                        break;
                    case "2":
                        DisplayEventDetails(reception);
                        break;
                    case "3":
                        DisplayEventDetails(outdoorGathering);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void DisplayEventDetails(Event eventDetails)
        {
            Console.WriteLine("\nSelect detail level:");
            Console.WriteLine("1. Standard Details");
            Console.WriteLine("2. Full Details");
            Console.WriteLine("3. Short Description");
            Console.Write("Enter your choice: ");
            string detailChoice = Console.ReadLine();

            switch (detailChoice)
            {
                case "1":
                    Console.WriteLine(eventDetails.StandardDetails());
                    break;
                case "2":
                    Console.WriteLine(eventDetails.FullDetails());
                    break;
                case "3":
                    Console.WriteLine(eventDetails.ShortDescription());
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}

