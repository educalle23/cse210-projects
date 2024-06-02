using System;
using System.Threading.Tasks;

public class Listing : Activity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    // Override method to run the listing activity
    protected override void RunActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Counter(5); 

        Console.WriteLine("Start listing items:");
        int countItem = 0;
        int finished = 0;
        while (finished < _duration)
        {
            Console.Write("Item: ");
            Console.ReadLine();
            countItem++;
            finished += 5;
        }

        Console.WriteLine($"You listed {countItem} items.");
    }
}