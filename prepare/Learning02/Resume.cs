using System;

public class Resume
{
    public string _name = "Eduardo Calle";

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Your name is {_name}");
        Console.WriteLine("Jobs:");

        foreach(Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}