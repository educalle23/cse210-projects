using System;
using System.Threading.Tasks;

public class Breathing : Activity
{
    public Breathing() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    protected override void RunActivity()
    {
        int finished = 0;
        while (finished < _duration)
        {
            Console.WriteLine("Breathe in...");
            Counter(7);
            finished += 7;

            if (finished >= _duration) break;

            Console.WriteLine("Breathe out...");
            Counter(5);
            finished += 5;
        }
    }
}