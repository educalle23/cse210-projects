using System;
using System.Threading.Tasks;


public abstract class Activity
{
    protected string _name; 
    protected string _description; 
    protected int _duration; 

    public Activity(string _name, string _description)
    {
        this._name = _name;
        this._description = _description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine(_description);
        Console.Write("Enter the _duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Counter(6); 
        RunActivity();
        End();
    }

    protected abstract void RunActivity();

    protected void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        Counter(3); 
    }

    protected void Counter(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Task.Delay(1000).Wait();
        }
        Console.WriteLine();
    }
}