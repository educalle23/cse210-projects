using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Initialize or load goals if necessary
        LoadGoals();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.ShortName);
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        var goal = _goals.Find(g => g.ShortName == goalName);
        if (goal != null)
        {
            int pointsEarned = goal.RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Recorded event for {goal.ShortName}, earned {pointsEarned} points.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(", ");
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (type == "SimpleGoal")
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        SimpleGoal goal = new SimpleGoal(name, description, points);
                        if (isComplete) goal.RecordEvent();
                        _goals.Add(goal);
                    }
                    else if (type == "EternalGoal")
                    {
                        EternalGoal goal = new EternalGoal(name, description, points);
                        _goals.Add(goal);
                    }
                    else if (type == "ChecklistGoal")
                    {
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                        for (int i = 0; i < amountCompleted; i++) goal.RecordEvent();
                        _goals.Add(goal);
                    }
                }
            }
        }
    }
}
