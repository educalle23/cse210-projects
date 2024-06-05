using System;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in technology.", new DateTime(2024, 6, 15), "10:00 AM", "123 Main St", "Dr. Smith", 100);
            Reception reception = new Reception("Networking Event", "An opportunity to meet and network with industry professionals.", new DateTime(2024, 6, 20), "6:00 PM", "456 Elm St", "rsvp@example.com");
            OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "A picnic for the whole community.", new DateTime(2024, 7, 4), "12:00 PM", "789 Park Ave", "Sunny");

            while (true)
            {
                Console.WriteLine("\nMaya Event Planning Menu:");
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
                    Console.WriteLine("\n" + eventDetails.StandardDetails() + "\n");
                    break;
                case "2":
                    Console.WriteLine("\n" + eventDetails.FullDetails() + "\n");
                    break;
                case "3":
                    Console.WriteLine("\n" + eventDetails.ShortDescription() + "\n");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
