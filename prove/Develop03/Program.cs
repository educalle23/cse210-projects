public class Program
{
    public static void ClearConsole()
    {
        Console.Clear();
    }

    public static void Main()
    {
        // Example scripture
        Reference reference = new Reference("Alma", 27, 29);
        string text = "I was in the darkest abyss; but now I behold the marvelous light of God. My soul was racked with eternal torment; but I am snatched, and my soul is pained no more";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            ClearConsole();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to end: ");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(2);
            if (scripture.IsCompletelyHidden())
            {
                ClearConsole();
                Console.WriteLine("All words are hidden.");
                break;
            }
        }
    }
}