using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();

        while (true)
        {
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("0. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.DisplayPlayerInfo();
                    break;
                case 2:
                    manager.ListGoalNames();
                    break;
                case 3:
                    manager.ListGoalDetails();
                    break;
                case 4:
                    CreateGoal(manager);
                    break;
                case 5:
                    Console.Write("Enter goal name: ");
                    string goalName = Console.ReadLine();
                    manager.RecordEvent(goalName);
                    manager.DisplayPlayerInfo();
                    break;
                case 6:
                    manager.SaveGoals();
                    break;
                case 7:
                    manager.LoadGoals();
                    break;
                case 0:
                    return;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                manager.CreateGoal(new SimpleGoal(name, description, points));
                break;
            case 2:
                manager.CreateGoal(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter target amount: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.CreateGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }
}
