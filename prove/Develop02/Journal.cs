using System.IO;
using Microsoft.VisualBasic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<VariantType> newEntry = new List<VariantType>();
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
                    // Journal newEntry = new Journal();
                    // string[] parts = line.Split(',');
                    // newEntry.date = parts[0];
                    // newEntry.promptText = parts[1];
                    // newEntry.entryText = parts[2];

                    // loadFile.Add(newEntry);
                }

            }
            Console.WriteLine("Journal loaded from file: " + loadFile);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading journal from file: " + ex.Message);
        }
    }

}