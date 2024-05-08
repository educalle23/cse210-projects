using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entryText)
    {
        _entries.Add(entryText);
    }
    public void DisplayAll()
    {
        Console.WriteLine("Journal Entries:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string saveFile)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(saveFile))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"Date: {entry.Date}, Prompt:{entry.PromptText},\n {entry.EntryText}");
                }
            }
            Console.WriteLine("Entries saved to file: " + saveFile);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving entries to file: " + ex.Message);
        }
    }

    public void LoadFromFile(string loadFile)
    {


        try
        {
            _entries.Clear(); // Clear existing entries before loading new ones
            using (StreamReader reader = new StreamReader(loadFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Journal newEntry = new Journal();
                    string date = parts[0];
                    string promptText = parts[1];
                    string entryText = parts[2];
                    // _entries.Add(newEntry);
                }


                //     if (parts.Length == 3)
                //     {
                //         string date = parts[0];
                //         string promptText = parts[1];
                //         string entryText = parts[2];
                //         _entries.Add(new Entry(date, promptText, entryText));
                //     }
                // }
            }
            Console.WriteLine("Journal loaded from file: " + loadFile);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading journal from file: " + ex.Message);
        }
    }

}