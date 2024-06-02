using System;
using System.Threading.Tasks;

public class Reflection: Activity
{
    private string[] prompts = new string[]
    {
        "Think of a time when you protected someone from harm.",
        "Think of a time when you accomplished something you thought was impossible.",
        "Think of a time when you extended a hand to someone in their darkest hour.",
        "Think of a time when you gave without expecting anything in return.",
        "Think of a time when you put someone else's needs before your own."
    };

    private string[] questions = new string[]
    {
       "Why did this matter to you?",
       "Have you done this before?",
       "How did you begin?",
       "How did you feel afterward?",
       "What made this time special?",
       "What was the best part?",
       "What can you use from this in other times?",
       "What did you find out about yourself?",
       "How can you remember this next time?"
    };

    public Reflection() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    // Override method to run the reflection activity
    protected override void RunActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Counter(5); 

        int elapsed = 0;
        while (elapsed < _duration)
        {
            string question = questions[rand.Next(questions.Length)];
            Console.WriteLine(question);
            Counter(5); 
            elapsed += 5;
        }
    }
}