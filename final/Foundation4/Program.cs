using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();
            
            while (true)
            {
                Console.WriteLine("\nExercise Tracking Menu:");
                Console.WriteLine("1. Add Running Activity");
                Console.WriteLine("2. Add Cycling Activity");
                Console.WriteLine("3. Add Swimming Activity");
                Console.WriteLine("4. Display All Activities");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        activities.Add(CreateActivity("Running"));
                        break;
                    case "2":
                        activities.Add(CreateActivity("Cycling"));
                        break;
                    case "3":
                        activities.Add(CreateActivity("Swimming"));
                        break;
                    case "4":
                        DisplayAllActivities(activities);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static Activity CreateActivity(string activityType)
        {
            Console.Write("Enter the date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the length in minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            switch (activityType)
            {
                case "Running":
                    Console.Write("Enter the distance in kilometers: ");
                    double runningDistance = double.Parse(Console.ReadLine());
                    return new Running(date, minutes, runningDistance);
                case "Cycling":
                    Console.Write("Enter the speed in kph: ");
                    double cyclingSpeed = double.Parse(Console.ReadLine());
                    return new Cycling(date, minutes, cyclingSpeed);
                case "Swimming":
                    Console.Write("Enter the number of laps: ");
                    int swimmingLaps = int.Parse(Console.ReadLine());
                    return new Swimming(date, minutes, swimmingLaps);
                default:
                    throw new ArgumentException("Invalid activity type");
            }
        }

        static void DisplayAllActivities(List<Activity> activities)
        {
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
