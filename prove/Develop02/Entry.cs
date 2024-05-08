public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string entryText)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _promptText = prompt;
        _entryText = entryText;
    }
    
    public string Date { get { return _date; } }
    public string PromptText { get { return _promptText; } }
    public string EntryText { get { return _entryText; } }
    
    public void Display()
    {
        Console.Write("Date: " + _date + " ");
        Console.WriteLine("Prompt: " + _promptText);
        Console.WriteLine("Entry: " + _entryText);
        Console.WriteLine();
    }
}